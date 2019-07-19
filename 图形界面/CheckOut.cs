using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 数据访问与类库;
using System;

namespace 图形界面
{
    public partial class CheckOut : Form
    {
        private bool isDClick = false;//标识是否搜索过用户了，防止直接结账
        private DataSet ds = new DataSet();
        private int id;
        string custormerName;
        string sex;
        string credentialNumber;
        string phone;
        DateTime checkInTime;
        DateTime checkOutTime;
        int days = 1;
        float spending;
        string roomType;
        string roomNumber;
        string remarks;
        float deposit;

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = DBHelper.ExecuteQuery("select ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '手机号',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as 备注 from CustomerInfo").Tables[0].DefaultView;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtRoomNumber.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAccountPayable.Text = string.Empty;
            txtDeposit.Text = string.Empty;
            txtPay.Text = string.Empty;
            txtChange.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            string sql= string.Empty;
            if (txtRoomNumber.Text.Trim()==""&&txtCustomerName.Text.Trim()=="")
            {
                sql = "select ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '手机号',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as 备注 from CustomerInfo";
            }
            else if (txtRoomNumber.Text.Trim() != "" & txtCustomerName.Text.Trim() != "")
            {
                sql = "select ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '手机号',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as 备注 from CustomerInfo where RoomNumber='" + txtRoomNumber.Text.Trim() + "' and CustomerName='" + txtCustomerName.Text.Trim() + "'";
            }
            else if (txtRoomNumber.Text.Trim() != "")
            {
                sql = "select ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '手机号',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as 备注 from CustomerInfo where RoomNumber='" + txtRoomNumber.Text.Trim() + "'";
            }
            else if (txtCustomerName.Text.Trim() != "")
            {
                sql = "select ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '手机号',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as 备注 from CustomerInfo where CustomerName='" + txtCustomerName.Text.Trim() + "'";
            }
            ds = DBHelper.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count<1)
            {
                MessageBox.Show("没有查到结果！");
                return;
            }
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Rows[0].Cells[0].Value.ToString();
            

        }

        //找零
        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (!int.TryParse(txtPay.Text, out val))
            {
                MessageBox.Show("输入正确的钱数！");
                return;
            }
            txtChange.Text = (deposit + val - spending).ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //判断搜索过了再进行结账
            if (!isDClick) { return; }
         
            if (DBHelper.Execute("insert into Record(CustomerName,Sex,CredentialNumber,Phone,CheckInTime,CheckOutTime,Days,Spending,RoomType,RoomNumber,Remarks) values('"
                +custormerName+"','"+sex+"','"+credentialNumber+"','"+phone+"','"+checkInTime+"','"+checkOutTime+"','"+days+"','"+spending+"','"+roomType+"','"+roomNumber+"','"+remarks+"')") > 0)
            {
                //进入代表记录历史记录成功
                if (DBHelper.Execute("delete from CustomerInfo where ID='" + id + "'") > 0)
                {
                    //进入代表删除宾客成功
                    if (DBHelper.Execute("update RoomInfo set RoomStatus='可供' where RoomNumber='" + roomNumber + "'") > 0)
                    {
                        //进入代表更改房间状态成功
                        MessageBox.Show("结算成功！");
                        isDClick = false;
                        dataGridView1.DataSource = null;
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isDClick = true;
            //给变量赋值

            id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            custormerName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            credentialNumber = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            phone = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            deposit = float.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            checkInTime = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            checkOutTime = System.DateTime.Now;
            days = Convert.ToInt32((checkOutTime - checkInTime).Days.ToString());
            if (days == 0)
            {
                days = 1;
            }
            roomType = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            roomNumber = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            remarks = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            spending = float.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString()) * days;

            //给界面赋值
            lblName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            lblRoom.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtAccountPayable.Text = spending.ToString();
            txtDeposit.Text = deposit.ToString();

        }
    }
}
