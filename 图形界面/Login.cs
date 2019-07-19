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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //点击登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ToLogin();
        }

        //密码框回车登录
        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                ToLogin();
            }
        }

        private void ToLogin()
        {
            //判断用户输入是否有误
            if (txtUserName.Text.Trim() == "" || txtUserPassword.Text.Trim() == "")
            {
                MessageBox.Show("输入有误！");
                return;
            }

            //将输入的密码进行加密再与数据库进行比对
            string password = MD5Helper.ToMD5(txtUserPassword.Text.Trim());
            DataSet ds = DBHelper.ExecuteQuery("select * from UserInfo where UserName='" + txtUserName.Text.Trim() + "' and UserPassword='" + password + "'");

            //查到此用户登录，否则登录失败
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                if (ds.Tables[0].Rows[0][2].ToString() == "操作员")
                {
                    new HotelManage(ds.Tables[0].Rows[0][0].ToString()).Show();
                }
                else
                {
                    new HotelManage(ds.Tables[0].Rows[0][0].ToString(),1).Show();
                }
            }
            else
            {
                MessageBox.Show("登录失败！");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
