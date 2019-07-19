using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 数据访问与类库;
using System.Collections;

namespace 图形界面
{
    public partial class HotelManage : Form
    {
        public string User { get; set; }

        //存对应tabPage对应的查询字符串
        private Dictionary<TabPage, string> dic = new Dictionary<TabPage, string>();
        //预准备好的图片
        private Image redHouseImage = Image.FromFile(@"../../Resources/redHouse.png");
        private Image blueHouseImgage = Image.FromFile(@"../../Resources/blueHouse.png");
        private Image greenHouseImage = Image.FromFile(@"../../Resources/greenHouse.png");

        //初始化字典
        private void Init()
        {
            dic.Add(tabPage1, "1=1");
            dic.Add(tabPage2, "RoomType='标准单人间'");
            dic.Add(tabPage3, "RoomType='标准双人间'");
            dic.Add(tabPage4, "RoomType='豪华单人间'");
            dic.Add(tabPage5, "RoomType='豪华双人间'");
            dic.Add(tabPage6, "RoomType='商务套房'");
            dic.Add(tabPage7, "RoomType='总统套房'");
        }

        public HotelManage(string str,int i)
        {
            InitializeComponent();
            tssaDown.Text += "管理员："+str;
            this.User = str;
        }

        public HotelManage(string str)
        {
            InitializeComponent();
            tsmiAdmin.Visible = false;
            tssaDown.Text += "操作员：" + str;
            this.User = str;
        }

        private void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HotelManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmiAddRoom_Click(object sender, EventArgs e)
        {
            new AddRoom().ShowDialog();
        }

        private void tsmiRoomManage_Click(object sender, EventArgs e)
        {
            new RoomManage().ShowDialog();
        }

        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            new CheckIn().ShowDialog();
        }
        private void tsbtnCheckIn_Click(object sender, EventArgs e)
        {
            new CheckIn().ShowDialog();
        }

        private void tsmiBookRoom_Click(object sender, EventArgs e)
        {
            new BookRoom().ShowDialog();
        }

        private void tsmiCancelReservation_Click(object sender, EventArgs e)
        {
            new CancelReservation().ShowDialog();
        }

        private void tsbtnBookRoom_Click(object sender, EventArgs e)
        {
            new BookRoom().ShowDialog();
        }

        private void tsbtnCheckOut_Click(object sender, EventArgs e)
        {
            new CheckOut().ShowDialog();
        }

        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            new CheckOut().ShowDialog();
        }

        private void tsmiPayDeposit_Click(object sender, EventArgs e)
        {
            new PayDeposit().ShowDialog();
        }

        private void tsmiRoomSearch_Click(object sender, EventArgs e)
        {
            new RoomSearch().ShowDialog();
        }

        private void tsmiCustomerSearch_Click(object sender, EventArgs e)
        {
            new CustomerSearch().ShowDialog();
        }

        private void tsmiBookSearch_Click(object sender, EventArgs e)
        {
            new BookSearch().ShowDialog();
        }

        private void tsmiAddUser_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
        }

        private void tsmiUserManage_Click(object sender, EventArgs e)
        {
            new UserManage().ShowDialog();
        }

        private void tsbtnRoomSearch_Click(object sender, EventArgs e)
        {
            new RoomSearch().ShowDialog();
        }

        private void tsbtnUser_Click(object sender, EventArgs e)
        {
            new UserManage().ShowDialog();
        }

        private void tsmiAdminSet_Click(object sender, EventArgs e)
        {
            new AdminSet(User).ShowDialog();
        }

        private void tsmiAddAdmin_Click(object sender, EventArgs e)
        {
            new AddAdmin().ShowDialog();
        }

        private void tsmiLimit_Click(object sender, EventArgs e)
        {
            new Business().ShowDialog();
        }

        private void tsbtnRecord_Click(object sender, EventArgs e)
        {
            new Business().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

       
        //窗体加载事件
        private void HotelManage_Load(object sender, EventArgs e)
        {
            Init();
            LoadHouseMap(tabPage1, dic[tabPage1]);
            LoadHouseMap(tabPage2, dic[tabPage2]);
            LoadHouseMap(tabPage3, dic[tabPage3]);
            LoadHouseMap(tabPage4, dic[tabPage4]);
            LoadHouseMap(tabPage5, dic[tabPage5]);
            LoadHouseMap(tabPage6, dic[tabPage6]);
            LoadHouseMap(tabPage7, dic[tabPage7]);
            
        }

        //窗体size改变时的重新赋值方法
        private void HotelManage_SizeChanged(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
            tabPage2.Controls.Clear();
            tabPage3.Controls.Clear();
            tabPage4.Controls.Clear();
            tabPage5.Controls.Clear();
            tabPage6.Controls.Clear();
            tabPage7.Controls.Clear();

            LoadHouseMap(tabPage1, dic[tabPage1]);
            LoadHouseMap(tabPage2, dic[tabPage2]);
            LoadHouseMap(tabPage3, dic[tabPage3]);
            LoadHouseMap(tabPage4, dic[tabPage4]);
            LoadHouseMap(tabPage5, dic[tabPage5]);
            LoadHouseMap(tabPage6, dic[tabPage6]);
            LoadHouseMap(tabPage7, dic[tabPage7]);
        }

        //刷新时的重新赋值方法
        private void btnUpdateMap_Click(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
            tabPage2.Controls.Clear();
            tabPage3.Controls.Clear();
            tabPage4.Controls.Clear();
            tabPage5.Controls.Clear();
            tabPage6.Controls.Clear();
            tabPage7.Controls.Clear();

            LoadHouseMap(tabPage1, dic[tabPage1]);
            LoadHouseMap(tabPage2, dic[tabPage2]);
            LoadHouseMap(tabPage3, dic[tabPage3]);
            LoadHouseMap(tabPage4, dic[tabPage4]);
            LoadHouseMap(tabPage5, dic[tabPage5]);
            LoadHouseMap(tabPage6, dic[tabPage6]);
            LoadHouseMap(tabPage7, dic[tabPage7]);
        }

        /// <summary>
        /// 动态加载动态图
        /// </summary>
        /// <param name="tbp">tabcontrol的页</param>
        /// <param name="addsql">添加筛选的sql</param>
        private void LoadHouseMap(TabPage tbp,string addsql)
        {
            DataSet ds = DBHelper.ExecuteQuery("select * from RoomInfo where 1=1 and " + addsql);
            Button[] btnArr = new Button[ds.Tables[0].Rows.Count];
            int leftPoint = 5;
            int topPoint = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //定义图片的样式
                btnArr[i] = new Button();
                btnArr[i].Width = 100;
                btnArr[i].Height = 100;
                btnArr[i].Text = ds.Tables[0].Rows[i][0].ToString();
                btnArr[i].Text += "\r\n" + ds.Tables[0].Rows[i][1].ToString();

                //给按钮附加标记信息(房间号)
                btnArr[i].Tag = ds.Tables[0].Rows[i][0].ToString();

                //对图片按钮进行定位
                btnArr[i].Left = leftPoint;
                btnArr[i].Top = topPoint;
                if (tbp.Right - leftPoint <= 210)//(i + 1) % 5 == 0)
                {
                    topPoint += 105;
                    leftPoint = 5;
                }
                else
                {
                    leftPoint += 105;
                }

                //添加图片
                if (ds.Tables[0].Rows[i][3].ToString() == "占用")
                {
                    btnArr[i].Image = redHouseImage;
                }
                else if (ds.Tables[0].Rows[i][3].ToString() == "预定")
                {
                    btnArr[i].Image = blueHouseImgage;
                }
                else
                {
                    btnArr[i].Image = greenHouseImage;
                }
                //添加事件
                btnArr[i].Click += new EventHandler(btnHouse_Click);
                btnArr[i].FlatStyle = FlatStyle.Flat;
                btnArr[i].Cursor = Cursors.Hand;
                //添加按钮
                tbp.Controls.Add(btnArr[i]);
            }
        }
        
        //房态按钮单击事件
        private void btnHouse_Click(object sender, EventArgs e)
        {
            new RoomShow(((Button)sender).Tag.ToString()).ShowDialog();
        }

        //tabcontrol切换时的刷新
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab.Controls.Clear();

            LoadHouseMap(tabControl.SelectedTab, dic[tabControl.SelectedTab]);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            new UserFeedBack().ShowDialog();
        }
    }
}
