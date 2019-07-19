namespace 图形界面
{
    partial class HotelManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelManage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomerSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRoomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdminSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHotel = new System.Windows.Forms.ToolStrip();
            this.tsbtnCheckIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBookRoom = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRoomSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUser = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRecord = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssaDown = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateMap = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tsHotel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomer,
            this.tsmiMoney,
            this.tsmiSearch,
            this.tsmiRoom,
            this.tsmiUser,
            this.tsmiBusiness,
            this.tsmiAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCustomer
            // 
            this.tsmiCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckIn,
            this.tsmiBookRoom,
            this.tsmiCancelReservation,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiCustomer.Name = "tsmiCustomer";
            this.tsmiCustomer.Size = new System.Drawing.Size(83, 20);
            this.tsmiCustomer.Text = "宾客登记(&C)";
            // 
            // tsmiCheckIn
            // 
            this.tsmiCheckIn.Name = "tsmiCheckIn";
            this.tsmiCheckIn.Size = new System.Drawing.Size(136, 22);
            this.tsmiCheckIn.Text = "宾客登记(&R)";
            this.tsmiCheckIn.Click += new System.EventHandler(this.tsmiCheckIn_Click);
            // 
            // tsmiBookRoom
            // 
            this.tsmiBookRoom.Name = "tsmiBookRoom";
            this.tsmiBookRoom.Size = new System.Drawing.Size(136, 22);
            this.tsmiBookRoom.Text = "宾客预定(&B)";
            this.tsmiBookRoom.Click += new System.EventHandler(this.tsmiBookRoom_Click);
            // 
            // tsmiCancelReservation
            // 
            this.tsmiCancelReservation.Name = "tsmiCancelReservation";
            this.tsmiCancelReservation.Size = new System.Drawing.Size(136, 22);
            this.tsmiCancelReservation.Text = "取消预订(&N)";
            this.tsmiCancelReservation.Click += new System.EventHandler(this.tsmiCancelReservation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(136, 22);
            this.tsmiExit.Text = "退出系统(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.AppExit);
            // 
            // tsmiMoney
            // 
            this.tsmiMoney.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCheckOut,
            this.tsmiPayDeposit});
            this.tsmiMoney.Name = "tsmiMoney";
            this.tsmiMoney.Size = new System.Drawing.Size(83, 20);
            this.tsmiMoney.Text = "收银结算(&P)";
            // 
            // tsmiCheckOut
            // 
            this.tsmiCheckOut.Name = "tsmiCheckOut";
            this.tsmiCheckOut.Size = new System.Drawing.Size(136, 22);
            this.tsmiCheckOut.Text = "退房结算(&O)";
            this.tsmiCheckOut.Click += new System.EventHandler(this.tsmiCheckOut_Click);
            // 
            // tsmiPayDeposit
            // 
            this.tsmiPayDeposit.Name = "tsmiPayDeposit";
            this.tsmiPayDeposit.Size = new System.Drawing.Size(136, 22);
            this.tsmiPayDeposit.Text = "补交押金(&D)";
            this.tsmiPayDeposit.Click += new System.EventHandler(this.tsmiPayDeposit_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomSearch,
            this.tsmiCustomerSearch,
            this.tsmiBookSearch});
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(83, 20);
            this.tsmiSearch.Text = "信息查询(&I)";
            // 
            // tsmiRoomSearch
            // 
            this.tsmiRoomSearch.Name = "tsmiRoomSearch";
            this.tsmiRoomSearch.Size = new System.Drawing.Size(136, 22);
            this.tsmiRoomSearch.Text = "房态查询(&R)";
            this.tsmiRoomSearch.Click += new System.EventHandler(this.tsmiRoomSearch_Click);
            // 
            // tsmiCustomerSearch
            // 
            this.tsmiCustomerSearch.Name = "tsmiCustomerSearch";
            this.tsmiCustomerSearch.Size = new System.Drawing.Size(136, 22);
            this.tsmiCustomerSearch.Text = "宾客查询(&C)";
            this.tsmiCustomerSearch.Click += new System.EventHandler(this.tsmiCustomerSearch_Click);
            // 
            // tsmiBookSearch
            // 
            this.tsmiBookSearch.Name = "tsmiBookSearch";
            this.tsmiBookSearch.Size = new System.Drawing.Size(136, 22);
            this.tsmiBookSearch.Text = "预定查询(&B)";
            this.tsmiBookSearch.Click += new System.EventHandler(this.tsmiBookSearch_Click);
            // 
            // tsmiRoom
            // 
            this.tsmiRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRoom,
            this.tsmiRoomManage});
            this.tsmiRoom.Name = "tsmiRoom";
            this.tsmiRoom.Size = new System.Drawing.Size(83, 20);
            this.tsmiRoom.Text = "客房管理(&R)";
            // 
            // tsmiAddRoom
            // 
            this.tsmiAddRoom.Name = "tsmiAddRoom";
            this.tsmiAddRoom.Size = new System.Drawing.Size(136, 22);
            this.tsmiAddRoom.Text = "客房添加(&A)";
            this.tsmiAddRoom.Click += new System.EventHandler(this.tsmiAddRoom_Click);
            // 
            // tsmiRoomManage
            // 
            this.tsmiRoomManage.Name = "tsmiRoomManage";
            this.tsmiRoomManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiRoomManage.Text = "客房管理(&M)";
            this.tsmiRoomManage.Click += new System.EventHandler(this.tsmiRoomManage_Click);
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUser,
            this.tsmiUserManage});
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(83, 20);
            this.tsmiUser.Text = "客户管理(&S)";
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(136, 22);
            this.tsmiAddUser.Text = "添加客户(&A)";
            this.tsmiAddUser.Click += new System.EventHandler(this.tsmiAddUser_Click);
            // 
            // tsmiUserManage
            // 
            this.tsmiUserManage.Name = "tsmiUserManage";
            this.tsmiUserManage.Size = new System.Drawing.Size(136, 22);
            this.tsmiUserManage.Text = "管理客户(&M)";
            this.tsmiUserManage.Click += new System.EventHandler(this.tsmiUserManage_Click);
            // 
            // tsmiBusiness
            // 
            this.tsmiBusiness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLimit});
            this.tsmiBusiness.Name = "tsmiBusiness";
            this.tsmiBusiness.Size = new System.Drawing.Size(83, 20);
            this.tsmiBusiness.Text = "业务管理(&T)";
            // 
            // tsmiLimit
            // 
            this.tsmiLimit.Name = "tsmiLimit";
            this.tsmiLimit.Size = new System.Drawing.Size(136, 22);
            this.tsmiLimit.Text = "营业记录(&M)";
            this.tsmiLimit.Click += new System.EventHandler(this.tsmiLimit_Click);
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdminSet,
            this.tsmiAddAdmin});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(77, 20);
            this.tsmiAdmin.Text = "管理员管理";
            // 
            // tsmiAdminSet
            // 
            this.tsmiAdminSet.Name = "tsmiAdminSet";
            this.tsmiAdminSet.Size = new System.Drawing.Size(130, 22);
            this.tsmiAdminSet.Text = "管理员设置";
            this.tsmiAdminSet.Click += new System.EventHandler(this.tsmiAdminSet_Click);
            // 
            // tsmiAddAdmin
            // 
            this.tsmiAddAdmin.Name = "tsmiAddAdmin";
            this.tsmiAddAdmin.Size = new System.Drawing.Size(130, 22);
            this.tsmiAddAdmin.Text = "添加管理员";
            this.tsmiAddAdmin.Click += new System.EventHandler(this.tsmiAddAdmin_Click);
            // 
            // tsHotel
            // 
            this.tsHotel.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsHotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCheckIn,
            this.tsbtnBookRoom,
            this.tsbtnCheckOut,
            this.tsbtnRoomSearch,
            this.tsbtnUser,
            this.tsbtnRecord});
            this.tsHotel.Location = new System.Drawing.Point(0, 24);
            this.tsHotel.Name = "tsHotel";
            this.tsHotel.Size = new System.Drawing.Size(790, 47);
            this.tsHotel.TabIndex = 1;
            this.tsHotel.Text = "toolStrip1";
            // 
            // tsbtnCheckIn
            // 
            this.tsbtnCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbtnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckIn.Image")));
            this.tsbtnCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckIn.Name = "tsbtnCheckIn";
            this.tsbtnCheckIn.Size = new System.Drawing.Size(97, 44);
            this.tsbtnCheckIn.Text = "宾客登记";
            this.tsbtnCheckIn.Click += new System.EventHandler(this.tsbtnCheckIn_Click);
            // 
            // tsbtnBookRoom
            // 
            this.tsbtnBookRoom.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBookRoom.Image")));
            this.tsbtnBookRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBookRoom.Name = "tsbtnBookRoom";
            this.tsbtnBookRoom.Size = new System.Drawing.Size(97, 44);
            this.tsbtnBookRoom.Text = "宾客预定";
            this.tsbtnBookRoom.Click += new System.EventHandler(this.tsbtnBookRoom_Click);
            // 
            // tsbtnCheckOut
            // 
            this.tsbtnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckOut.Image")));
            this.tsbtnCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckOut.Name = "tsbtnCheckOut";
            this.tsbtnCheckOut.Size = new System.Drawing.Size(97, 44);
            this.tsbtnCheckOut.Text = "退房结算";
            this.tsbtnCheckOut.Click += new System.EventHandler(this.tsbtnCheckOut_Click);
            // 
            // tsbtnRoomSearch
            // 
            this.tsbtnRoomSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRoomSearch.Image")));
            this.tsbtnRoomSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRoomSearch.Name = "tsbtnRoomSearch";
            this.tsbtnRoomSearch.Size = new System.Drawing.Size(97, 44);
            this.tsbtnRoomSearch.Text = "房态查询";
            this.tsbtnRoomSearch.Click += new System.EventHandler(this.tsbtnRoomSearch_Click);
            // 
            // tsbtnUser
            // 
            this.tsbtnUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUser.Image")));
            this.tsbtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUser.Name = "tsbtnUser";
            this.tsbtnUser.Size = new System.Drawing.Size(97, 44);
            this.tsbtnUser.Text = "用户管理";
            this.tsbtnUser.Click += new System.EventHandler(this.tsbtnUser_Click);
            // 
            // tsbtnRecord
            // 
            this.tsbtnRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRecord.Image")));
            this.tsbtnRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRecord.Name = "tsbtnRecord";
            this.tsbtnRecord.Size = new System.Drawing.Size(97, 44);
            this.tsbtnRecord.Text = "营业记录";
            this.tsbtnRecord.Click += new System.EventHandler(this.tsbtnRecord_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssaDown});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tssaDown
            // 
            this.tssaDown.BackColor = System.Drawing.Color.MintCream;
            this.tssaDown.Name = "tssaDown";
            this.tssaDown.Size = new System.Drawing.Size(155, 17);
            this.tssaDown.Text = "欢迎进入酒店客房管理系统,";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTimer.Location = new System.Drawing.Point(672, 6);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(53, 12);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "现在时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(581, 116);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(100, 23);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = " ";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreen.BackColor = System.Drawing.Color.Lime;
            this.lblGreen.Location = new System.Drawing.Point(581, 200);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(100, 23);
            this.lblGreen.TabIndex = 0;
            this.lblGreen.Text = " ";
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlue.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblBlue.Location = new System.Drawing.Point(581, 158);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(100, 23);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = " ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(699, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "占用";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(699, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "预定";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(699, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "可供";
            // 
            // btnUpdateMap
            // 
            this.btnUpdateMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateMap.Location = new System.Drawing.Point(626, 255);
            this.btnUpdateMap.Name = "btnUpdateMap";
            this.btnUpdateMap.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMap.TabIndex = 10;
            this.btnUpdateMap.Text = "刷新房态";
            this.btnUpdateMap.UseVisualStyleBackColor = true;
            this.btnUpdateMap.Click += new System.EventHandler(this.btnUpdateMap_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Location = new System.Drawing.Point(0, 76);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(575, 411);
            this.tabControl.TabIndex = 11;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "所有类型";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "标准单人间";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(567, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "标准双人间";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(567, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "豪华单人间";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(567, 386);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "豪华双人间";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 21);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(567, 386);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "商务套房";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 21);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(567, 386);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "总统套房";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // HotelManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(790, 512);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnUpdateMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsHotel);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotelManage";
            this.Opacity = 0.95;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店客房管理系统";
            this.Load += new System.EventHandler(this.HotelManage_Load);
            this.SizeChanged += new System.EventHandler(this.HotelManage_SizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelManage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsHotel.ResumeLayout(false);
            this.tsHotel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoney;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCheckOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayDeposit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomerSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManage;
        private System.Windows.Forms.ToolStrip tsHotel;
        private System.Windows.Forms.ToolStripButton tsbtnCheckIn;
        private System.Windows.Forms.ToolStripButton tsbtnBookRoom;
        private System.Windows.Forms.ToolStripButton tsbtnCheckOut;
        private System.Windows.Forms.ToolStripButton tsbtnRoomSearch;
        private System.Windows.Forms.ToolStripButton tsbtnUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssaDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdminSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAdmin;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimit;
        private System.Windows.Forms.ToolStripButton tsbtnRecord;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateMap;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
    }
}