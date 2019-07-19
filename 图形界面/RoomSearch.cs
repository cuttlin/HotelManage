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
    public partial class RoomSearch : Form
    {
        private DataSet ds = new DataSet();
        public RoomSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where 1=1";
            if(txtRoomNumber.Text.Trim()!="")
            {
                sql += "and RoomNumber='" + txtRoomNumber.Text.Trim() + "'";
            }

            if (cboRoomType.Text!="")
            {
                sql += "and RoomType='" + cboRoomType.Text + "'";
            }

            if (cboRoomStatus.Text!="")
            {
                sql += "and RoomStatus='" + cboRoomStatus.Text + "'";
            }

            ds=DBHelper.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
