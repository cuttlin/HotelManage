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
    public partial class RoomShow : Form
    {
        private string RoomNumber { get; set; }//房间号
        private DataSet ds = new DataSet();
        private DataSet ds2 = new DataSet();
        public RoomShow(string btnTag)
        {
            this.RoomNumber = btnTag;
            InitializeComponent();

            ds = DBHelper.ExecuteQuery("select RoomNumber as '房间号',RoomType as '房间类型',RoomPrice as '房间价格',RoomStatus as '房间状态',Remarks as '房间说明' from RoomInfo where RoomNumber='"+RoomNumber+"'");
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            string sql = "select ID as 'ID',CustomerName as '顾客姓名',Phone as '联系电话',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',RoomPrice as '房间价格',Remarks as '备注' from BookInfo";
            if (ds.Tables[0].Rows[0][3].ToString()=="占用")
            {
                sql = "select ID,CustomerName as '顾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '联系电话',Deposit as '押金',CheckInTime as '入住时间',Days as '预计天数',Remarks as '备注' from CustomerInfo where RoomNumber='" + RoomNumber + "'";
            }
            ds2 = DBHelper.ExecuteQuery(sql);
            this.dataGridView2.DataSource = ds2.Tables[0].DefaultView;
        }
    }
}
