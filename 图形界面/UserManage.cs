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
    public partial class UserManage : Form
    {
        private DataSet ds = new DataSet();
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            ds = DBHelper.ExecuteQuery("select username as '用户名',telephone as '电话' from WebUser");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        //双击赋值
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请选择要删除的用户!");
                return;
            }
            if (DBHelper.Execute("delete WebUser where username='" + txtUserName.Text.Trim() + "'") > 0)
            {
                MessageBox.Show("删除成功！");

                ds = DBHelper.ExecuteQuery("select username as '用户名',telephone as '电话' from WebUser");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                txtUserName.Text = string.Empty;
                txtUserPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = MD5Helper.ToMD5(txtUserPassword.Text.Trim());
            string telephone = txtPhone.Text.Trim();
            string sql = "update WebUser set telephone='" + telephone + "' where username='" + userName + "'";
            if (cboPwd.Checked) 
            {
                sql = "update WebUser set password='" + password + "',telephone='" + telephone + "' where username='" + userName + "'";
                if (txtUserPassword.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }
            }
            if (DBHelper.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");

                ds = DBHelper.ExecuteQuery("select username as '用户名',telephone as '电话' from WebUser");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                txtUserName.Text = string.Empty;
                txtUserPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
        }

        private void cboPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cboPwd.Checked)
            {
                txtUserPassword.Enabled = true;
            }
            else
            {
                txtUserPassword.Text = string.Empty;
                txtUserPassword.Enabled = false;
            }
        }
    }
}
