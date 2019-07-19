using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 数据访问与类库;

namespace 图形界面
{
    public partial class BookRoom : Form
    {
        private DataSet ds = new DataSet();
        public BookRoom()
        {
            InitializeComponent();
            cboDeposit.SelectedIndex = 0;
            ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where RoomStatus='可供'");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cboDeposit.SelectedIndex = 2;
            txtDays.Text = string.Empty;
            txtRoomPrice.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtRoomRemarks.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomNumber.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtRoomType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtRoomPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtRoomRemarks.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //赋值操作
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("请输入正确的内容！");
                return;
            }
            string customerName = txtCustomerName.Text.Trim();
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
                MessageBox.Show("请输入正确的内容price！");
                return;
            }
            string roomType = txtRoomType.Text.Trim();
            string roomNumber = txtRoomNumber.Text.Trim();
            string remarks = txtRemarks.Text.Trim();

            //DB操作
            if (DBHelper.Execute(@"insert into BookInfo(CustomerName,Phone,Deposit,CheckInTime,Days,RoomPrice,RoomType,RoomNumber,Remarks) values(
            '" + customerName + "','" + phone + "','" + deposit + "','" + checkInTime + "','" + days + "','" + roomPrice + "','" + roomType + "','" + roomNumber + "','" + remarks + "')") > 0)
            {
                if (DBHelper.Execute("update RoomInfo set RoomStatus='预定' where RoomNumber='" + Convert.ToInt32(txtRoomNumber.Text.Trim()) + "'") > 0)
                {
                    MessageBox.Show("预订成功！");
                    ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where RoomStatus='可供'");
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else
            {
                MessageBox.Show("预定失败！");
            }
        }

    }
}
