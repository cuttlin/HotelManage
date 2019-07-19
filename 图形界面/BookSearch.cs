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
    public partial class BookSearch : Form
    {
        private DataSet ds = new DataSet();
        public BookSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select ID,CustomerName as '宾客姓名',Phone as '电话号码',Deposit as '已交押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as '备注' from BookInfo where 1=1";
            if (txtCustomerName.Text!="")
            {
                sql += "and CustomerName ='" + txtCustomerName.Text + "'";
            }

            if (txtRoomNumber.Text!="")
            {
                sql += "and RoomNumber='" + txtRoomNumber.Text + "'";
            }

            if (txtPhone.Text!="")
            {
                sql += "and Phone='" + txtPhone.Text + "'";
            }

            if (txtCheckInTime.Text!="")
            {
                sql += "and CheckInTime='" + txtCheckInTime.Text + "'";
            }
            ds = DBHelper.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
