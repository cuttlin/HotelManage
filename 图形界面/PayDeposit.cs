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
    public partial class PayDeposit : Form
    {
        private DataSet ds = new DataSet();
        private int id;//用户的ID
        private int deposit;//之前交的押金

        public PayDeposit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int roomNumber;
            if (!int.TryParse(txtInpuyRoomNumber.Text.Trim(), out roomNumber))
            {
                MessageBox.Show("输入有误！");
                return;
            }
            ds =DBHelper.ExecuteQuery("select * from CustomerInfo where RoomNumber='" + roomNumber + "'");
            if (!(ds.Tables[0].Rows.Count>0))
            {
                MessageBox.Show("没有此房间的信息！");
                return;
            }
            id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            deposit = int.Parse(ds.Tables[0].Rows[0][5].ToString());
            txtCustomerName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtRoomNumber.Text = ds.Tables[0].Rows[0][10].ToString();
            txtCheckInTime.Text = ds.Tables[0].Rows[0][6].ToString();
            txtRoomPrice.Text = ds.Tables[0].Rows[0][8].ToString();
            txtDeposit.Text = deposit.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int newMoney;
            if (!int.TryParse(txtPayDeposit.Text.Trim(),out newMoney))
            {
                MessageBox.Show("补交输入有误！");
                return;
            }
            deposit += newMoney;
            if (DBHelper.Execute("update CustomerInfo set Deposit='" + deposit + "' where ID='" + id + "'") > 0)
            {
                MessageBox.Show("补交押金成功！");
            }
            else
            {
                MessageBox.Show("补交押金失败！");
            }
        }


    }
}
