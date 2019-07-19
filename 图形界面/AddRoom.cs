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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            cboRoomType.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(txtRoomNumber.Text.Trim()!=""&&txtRoomPrice.Text.Trim()!=""))
            {
                MessageBox.Show("请输入正确的内容！");
                return;
            }

            int roomNumber,roomPrice;
            if (!(int.TryParse(txtRoomNumber.Text.Trim(), out roomNumber) && int.TryParse(txtRoomPrice.Text.Trim(), out roomPrice)))
            {
                MessageBox.Show("请输入正确的内容！");
                return;
            }
            //判断是否已经有了此房间
            DataSet ds = DBHelper.ExecuteQuery("select RoomNumber from RoomInfo where RoomNumber='" + roomNumber + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("已有此房间！");
                return;
            }

            string roomType = cboRoomType.SelectedItem.ToString();
;
            string remarks=txtRemarks.Text.Trim();
            if (DBHelper.Execute("insert into RoomInfo(RoomNumber,RoomType,RoomPrice,Remarks) values('" + roomNumber + "','"
                + roomType + "','" + roomPrice + "','" + remarks + "')") > 0)
            {
                MessageBox.Show("客房添加成功！");
                cboRoomType.SelectedIndex = 0;
                txtRoomNumber.Text = string.Empty;
                txtRoomPrice.Text = string.Empty;
                txtRemarks.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("客房添加失败！");
            }

        }
    }
}
