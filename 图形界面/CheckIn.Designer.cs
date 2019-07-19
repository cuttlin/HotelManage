namespace 图形界面
{
    partial class CheckIn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDeposit = new System.Windows.Forms.ComboBox();
            this.txtRoomRemarks = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtCredentialNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.btnBookCus = new System.Windows.Forms.Button();
            this.btnSwich = new System.Windows.Forms.Button();
            this.lblSwich = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(336, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "宾客姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性　　别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "证件号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "入住时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "预计天数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "备注信息：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDeposit);
            this.groupBox1.Controls.Add(this.txtRoomRemarks);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.txtRoomPrice);
            this.groupBox1.Controls.Add(this.txtRoomType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(39, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择客房";
            // 
            // cboDeposit
            // 
            this.cboDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeposit.FormattingEnabled = true;
            this.cboDeposit.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cboDeposit.Location = new System.Drawing.Point(216, 45);
            this.cboDeposit.Name = "cboDeposit";
            this.cboDeposit.Size = new System.Drawing.Size(71, 20);
            this.cboDeposit.TabIndex = 9;
            // 
            // txtRoomRemarks
            // 
            this.txtRoomRemarks.Enabled = false;
            this.txtRoomRemarks.Location = new System.Drawing.Point(73, 76);
            this.txtRoomRemarks.Multiline = true;
            this.txtRoomRemarks.Name = "txtRoomRemarks";
            this.txtRoomRemarks.Size = new System.Drawing.Size(214, 58);
            this.txtRoomRemarks.TabIndex = 8;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(73, 45);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(71, 21);
            this.txtRoomNumber.TabIndex = 7;
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Enabled = false;
            this.txtRoomPrice.Location = new System.Drawing.Point(216, 17);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(71, 21);
            this.txtRoomPrice.TabIndex = 6;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Enabled = false;
            this.txtRoomType.Location = new System.Drawing.Point(72, 17);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(71, 21);
            this.txtRoomType.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "客房备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "押　　金：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "客房号码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "客房价格：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "客房类型：";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(108, 21);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerName.TabIndex = 9;
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(108, 49);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(140, 20);
            this.cboSex.TabIndex = 10;
            // 
            // txtCredentialNumber
            // 
            this.txtCredentialNumber.Location = new System.Drawing.Point(108, 77);
            this.txtCredentialNumber.Name = "txtCredentialNumber";
            this.txtCredentialNumber.Size = new System.Drawing.Size(140, 21);
            this.txtCredentialNumber.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(108, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 21);
            this.txtPhone.TabIndex = 12;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(108, 160);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(140, 21);
            this.txtDays.TabIndex = 14;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(108, 188);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(227, 21);
            this.txtRemarks.TabIndex = 15;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(39, 370);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 16;
            this.btnCheckIn.Text = "入住";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(152, 370);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Location = new System.Drawing.Point(108, 132);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(140, 21);
            this.dtpCheckInTime.TabIndex = 19;
            // 
            // btnBookCus
            // 
            this.btnBookCus.Font = new System.Drawing.Font("宋体", 7F);
            this.btnBookCus.ForeColor = System.Drawing.Color.Blue;
            this.btnBookCus.Location = new System.Drawing.Point(254, 159);
            this.btnBookCus.Name = "btnBookCus";
            this.btnBookCus.Size = new System.Drawing.Size(85, 21);
            this.btnBookCus.TabIndex = 20;
            this.btnBookCus.Text = "查询已预订宾客";
            this.btnBookCus.UseVisualStyleBackColor = true;
            this.btnBookCus.Click += new System.EventHandler(this.btnBookCus_Click);
            // 
            // btnSwich
            // 
            this.btnSwich.Location = new System.Drawing.Point(702, 164);
            this.btnSwich.Name = "btnSwich";
            this.btnSwich.Size = new System.Drawing.Size(25, 39);
            this.btnSwich.TabIndex = 21;
            this.btnSwich.Text = "<<";
            this.btnSwich.UseVisualStyleBackColor = true;
            this.btnSwich.Click += new System.EventHandler(this.btnSwich_Click);
            // 
            // lblSwich
            // 
            this.lblSwich.AutoSize = true;
            this.lblSwich.Location = new System.Drawing.Point(503, 9);
            this.lblSwich.Name = "lblSwich";
            this.lblSwich.Size = new System.Drawing.Size(65, 12);
            this.lblSwich.TabIndex = 22;
            this.lblSwich.Text = "*客房总表*";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(362, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(336, 361);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 404);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblSwich);
            this.Controls.Add(this.btnSwich);
            this.Controls.Add(this.btnBookCus);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCredentialNumber);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckIn";
            this.Opacity = 0.95;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宾客登记";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtCredentialNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtRoomRemarks;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cboDeposit;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Button btnBookCus;
        private System.Windows.Forms.Button btnSwich;
        private System.Windows.Forms.Label lblSwich;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}