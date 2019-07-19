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
    public partial class AdminSet : Form
    {
        public string User { get; set; }
        public AdminSet(string user)
        {
            this.User = user;
            InitializeComponent();
            cboType.SelectedIndex = 0;
            dataGridView1.DataSource = DBHelper.ExecuteQuery("select UserName as '用户名',UserType as '用户类型' from UserInfo").Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cboType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void cbxIsAlterPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsAlterPwd.Checked)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;                
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string usertype = cboType.Text;
            string password;
            string sql = "update UserInfo set UserName='" + username + "',UserType='" + usertype + "' where UserName='" + username + "'";
            /*
             * 判断是否选择了修改密码
             * 选择就修改sql语句
             */
            if (cbxIsAlterPwd.Checked)
            {
                password = MD5Helper.ToMD5(txtPassword.Text.Trim());    
                sql = "update UserInfo set UserName='"+username+"',UserPassword='"+password+"',UserType='"+usertype+"' where UserName='"+username+"'";
            }
            
            if (DBHelper.Execute(sql)>0)
            {
                MessageBox.Show("修改成功！");
                dataGridView1.DataSource = DBHelper.ExecuteQuery("select UserName as '用户名',UserPassword as '密码',UserType as '用户类型' from UserInfo").Tables[0];
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cboType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string usertype = cboType.Text;
            if (User == DBHelper.ExecuteQuery("select * from UserInfo where UserName='" + username + "'").Tables[0].Rows[0][0].ToString())
            {
                MessageBox.Show("不删除本用户！");
                return;
            }
            if (DBHelper.Execute("delete from UserInfo where UserName='" + username + "'") > 0)
            {
                MessageBox.Show("删除成功！");
                dataGridView1.DataSource = DBHelper.ExecuteQuery("select UserName as '用户名',UserPassword as '密码',UserType as '用户类型' from UserInfo").Tables[0];
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cboType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        
    }
}
