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
    public partial class CancelReservation : Form
    {
        private DataSet ds = new DataSet();
        private int iD = 0;
        public CancelReservation()
        {
            InitializeComponent();
            ds = DBHelper.ExecuteQuery("select ID as 'ID',CustomerName as '顾客姓名',Phone as '联系电话',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as '备注' from BookInfo");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            iD = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtCustomerName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cboDeposit.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dtpCheckInTime.Value = (DateTime)dataGridView1.SelectedRows[0].Cells[4].Value;
            txtDays.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtRoomPrice.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtRoomType.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtRoomNumber.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtRemarks.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (iD==0)
            {
                MessageBox.Show("请选择要取消预订的客户！");
                return;
            }
            if (DBHelper.Execute("delete from BookInfo where ID='" + iD + "'") > 0&&DBHelper.Execute("update RoomInfo set RoomStatus='可供' where RoomNumber='"+Convert.ToInt32( txtRoomNumber.Text.Trim())+"'")>0)
            {
                MessageBox.Show("取消预订成功！");
                ds = DBHelper.ExecuteQuery("select ID as 'ID',CustomerName as '顾客姓名',Phone as '联系电话',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as '备注' from BookInfo");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
            else
            {
                MessageBox.Show("取消预订失败！");
            }
        }

        //删除所有预定房间操作
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您是否要清空所有用户预订的房间？(此操作不可恢复)", "警告！", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                if (DBHelper.Execute("update RoomInfo set RoomStatus='可供' where RoomStatus='预定'") > 0 && DBHelper.Execute("delete from BookInfo where 1=1") > 0)
                {
                    MessageBox.Show("清空成功！");
                }
            }
        }
    }
}
