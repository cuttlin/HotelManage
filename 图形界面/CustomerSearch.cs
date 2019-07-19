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
    public partial class CustomerSearch : Form
    {
        private DataSet ds = new DataSet();
        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select ID,CustomerName as '宾客姓名',Sex as '宾客性别',CredentialNumber as '身份证号',Phone as '电话号码',Deposit as '已交押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',RoomType as '房间类型',RoomNumber as '房间号码',Remarks as '备注' from CustomerInfo where 1=1";
            if (txtCustomerName.Text!="")
            {
                sql += "and CustomerName = '" + txtCustomerName.Text + "'";
            }

            if (txtRoomNumber.Text!="")
            {
                sql += "and RoomNumber = '" + txtRoomNumber.Text + "'";
            }

            if (txtCredentialNumber.Text!="")
            {
                sql += "and CredentialNumber = '" + txtCredentialNumber.Text + "'";
            }

            if (cboSex.Text!="")
            {
                sql += "and Sex = '" + cboSex.Text + "'";
            }
            ds = DBHelper.ExecuteQuery(sql);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
