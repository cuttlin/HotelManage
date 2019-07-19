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
    public partial class RoomManage : Form
    {
        private DataSet ds = new DataSet();
        public RoomManage()
        {
            InitializeComponent();
        }

        private void RoomManage_Load(object sender, EventArgs e)
        {
            ds =DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo");
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            cboRoomType.SelectedIndex = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomNumber.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string roomType = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            foreach (string item in cboRoomType.Items)
            {
                if (roomType==item)
                {
                    cboRoomType.SelectedItem = item;
                }
            }
            txtRoomPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtRemarks.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        //修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int roomNumber,roomPrice;
            if (!(int.TryParse(txtRoomNumber.Text.Trim(), out roomNumber)&&int.TryParse(txtRoomPrice.Text.Trim(),out roomPrice)))
            {
                MessageBox.Show("输入有误！");
                return ;
            }
            string roomType = cboRoomType.SelectedItem.ToString();
            string roomMarks = txtRemarks.Text.Trim();

            if (DBHelper.Execute("update RoomInfo set RoomType='" + roomType + "',RoomPrice='"
                + roomPrice + "',Remarks='" + roomMarks + "' where RoomNumber='" + roomNumber + "'") > 0)
            {
                MessageBox.Show("修改成功！");
                ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo");
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int roomNumber;
            if (!(int.TryParse(txtRoomNumber.Text.Trim(), out roomNumber)))
            {
                MessageBox.Show("宿舍号输入有误！");
                return;
            }
            if (DBHelper.Execute("delete RoomInfo where RoomNumber='" + roomNumber + "'") > 0)
            {
                MessageBox.Show("删除成功！");
                ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo");
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
                cboRoomType.SelectedIndex = 0;
                txtRoomNumber.Text = string.Empty;
                txtRoomPrice.Text = string.Empty;
                txtRemarks.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
