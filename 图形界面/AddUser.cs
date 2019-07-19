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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim()==""||txtUserPassword.Text.Trim()=="")
            {
                MessageBox.Show("请输入完整的信息!");
                return;
            }
            string userName = txtUserName.Text.Trim();
            //判断是否已经有了此用户
            DataSet ds = DBHelper.ExecuteQuery("select username from WebUser where username='" + userName + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("已有此用户！");
                return;
            }
            string password = MD5Helper.ToMD5( txtUserPassword.Text.Trim());
            string phone = txtPhone.Text;
            if (DBHelper.Execute("insert into WebUser(username,password,telephone) values('" + userName + "','" + password + "','" + phone + "')") > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
