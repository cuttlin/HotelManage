using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 数据访问与类库;
using System.Text.RegularExpressions;

namespace 图形界面
{
    public partial class CheckIn : Form
    {
        private DataSet ds = new DataSet();
        private string RoomStatus { get; set; }//标识房间是否被预订，方便预定房间入住时删除预订信息
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            cboSex.SelectedIndex = 0;
            cboDeposit.SelectedIndex = 0;
            ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where Roomstatus<>'占用'");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView2.Visible = false;
        }

        //双击赋值
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRoomNumber.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtRoomType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtRoomPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtRoomRemarks.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            RoomStatus = "可供";
            //如果房间已经被预订，则显示预定客人的信息
            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "预定")
            {
               DataSet tempDs = DBHelper.ExecuteQuery("select * from BookInfo where RoomNumber='"+dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"'");
               txtCustomerName.Text = tempDs.Tables[0].Rows[0][1].ToString();
               txtPhone.Text = tempDs.Tables[0].Rows[0][2].ToString();
               RoomStatus = "预定";
            }
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRoomNumber.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            txtRoomType.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txtRoomPrice.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            txtRoomRemarks.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            RoomStatus = "可供";
            //如果房间已经被预订，则显示预定客人的信息
            if (dataGridView2.SelectedRows[0].Cells[3].Value.ToString() == "预定")
            {
                DataSet tempDs = DBHelper.ExecuteQuery("select * from BookInfo where RoomNumber='" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'");
                txtCustomerName.Text = tempDs.Tables[0].Rows[0][1].ToString();
                txtPhone.Text = tempDs.Tables[0].Rows[0][2].ToString();
                RoomStatus = "预定";
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            cboSex.SelectedIndex = 0;
            txtCredentialNumber.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cboDeposit.SelectedIndex = 2;
            txtDays.Text = string.Empty;
            txtRoomPrice.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtRoomRemarks.Text = string.Empty;
        }

        //入住按钮
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //赋值操作
            if (txtCustomerName.Text.Trim() == "" || txtCredentialNumber.Text.Trim() == "")
            {
                MessageBox.Show("请输入正确的内容！");
                return;
            }
            string customerName = txtCustomerName.Text.Trim();
            string sex = cboSex.SelectedItem.ToString();
            string credentialNumber = txtCredentialNumber.Text.Trim();
            if(!Regex.IsMatch(credentialNumber,@"^\d{15}|\d{18}|\d{17}\w$"))
            {
                MessageBox.Show("身份证号格式错误！");
                return;
            }
            string phone = txtPhone.Text.Trim();
            int deposit = int.Parse(cboDeposit.SelectedItem.ToString());
            DateTime checkInTime = dtpCheckInTime.Value;
            int days;
            if (!int.TryParse(txtDays.Text.Trim(), out days))
            {
                MessageBox.Show("请输入正确的内容days！");
                return;
            }
            double roomPrice;
            if (!double.TryParse(txtRoomPrice.Text.Trim(), out roomPrice))
            {
                MessageBox.Show("请先选择要入住的房间！");
                return;
            }
            string roomType = txtRoomType.Text.Trim();
            string roomNumber = txtRoomNumber.Text.Trim();
            string remarks = txtRemarks.Text.Trim();

            //DB操作
            if (DBHelper.Execute(@"insert into CustomerInfo(CustomerName,Sex,CredentialNumber,Phone,Deposit,CheckInTime,Days,RoomPrice,RoomType,RoomNumber,Remarks) values(
            '" + customerName + "','" + sex + "','" + credentialNumber + "','" + phone + "','" + deposit + "','" + checkInTime + "','" + days + "','" + roomPrice + "','" + roomType + "','" + roomNumber + "','" + remarks + "')") > 0)
            {
                if (DBHelper.Execute("update RoomInfo set RoomStatus='占用' where RoomNumber='" + roomNumber + "'") > 0)
                {
                    MessageBox.Show("入住成功！");
                    if (RoomStatus == "预定")
                    {
                        DBHelper.Execute("delete from BookInfo where RoomNumber='" + roomNumber + "'");
                    }
                    //刷新datagridview1
                    ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where Roomstatus<>'占用'");
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView2.DataSource = null;
                }
                else                                                                                                                                                                  
                {
                    MessageBox.Show("入住失败！");
                }
            }
            else
            {
                MessageBox.Show("添加旅客失败！");
            }
        }

        //查看已预订房间客人
        private void btnBookCus_Click(object sender, EventArgs e)
        {
            //判断输入是否有误
            if (txtCustomerName.Text.Trim() == "" && txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("请输入宾客姓名/电话号码进行查询！");
                return;
            }
            //sql语句赋值
            string sql = "select RoomNumber from BookInfo where 1=1";
            if (txtCustomerName.Text.Trim() != "")
            {
                sql += "and CustomerName='" + txtCustomerName.Text.Trim() + "'";
            }
            if (txtPhone.Text.Trim()!="")
            {
                sql += "and Phone='" + txtPhone.Text.Trim() + "'";
            }

            //判断查询的结果
            DataSet tempDs = DBHelper.ExecuteQuery(sql);
            if (tempDs.Tables[0].Rows.Count<=0)
            {
                MessageBox.Show("没有您要查询的用户的预订信息！");
                return;
            }
            //给用户已预订房间的datagridview赋值
            dataGridView2.DataSource = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where RoomNumber in("+sql+")").Tables[0].DefaultView;
            //转到用户已预订房间的界面
            btnSwich.Text = ">>";
            lblSwich.Text = "*查询的已预订房间*";
            dataGridView2.Visible = true;
        }

        //切换显示的datagridview
        private void btnSwich_Click(object sender, EventArgs e)
        {
            if (btnSwich.Text == "<<")
            {
                btnSwich.Text = ">>";
                lblSwich.Text = "*查询的已预订房间*";
                dataGridView2.Visible = true;
            }
            else
            {
                btnSwich.Text = "<<";
                lblSwich.Text = "*客房总表*";
                dataGridView2.Visible = false;
            }
        }

       
    }
}
