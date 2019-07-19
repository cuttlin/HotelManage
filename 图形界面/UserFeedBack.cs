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
    public partial class UserFeedBack : Form
    {
        public UserFeedBack()
        {
            InitializeComponent();
        }

        private void UserFeedBack_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBHelper.ExecuteQuery("select username as '用户名',usermsg as '反馈信息' from FeedBack").Tables[0].DefaultView;
        }
    }
}
