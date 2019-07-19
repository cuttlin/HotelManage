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
    public partial class Business : Form
    {
        private DataSet dataSet = new DataSet();
        //查询重命名字段
        private string words = "ID,CustomerName as '宾客姓名',Sex as '性别',CredentialNumber as '身份证号',Phone as '电话号码',CheckInTime as '入住时间',CheckOutTime as '离开时间',Days as '预计天数',Spending as '花费',RoomType as '房间类型',RoomNumber as '房间号',Remarks as '备注'";
        public Business()
        {
            InitializeComponent();
        }

        private void Business_Load(object sender, EventArgs e)
        {
            dataSet = DBHelper.ExecuteQuery("select "+words+" from Record");
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

            // 本周营业额
                //今天
            DateTime dt = DateTime.Now;
                //本周周一
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));
            DataSet ds = DBHelper.ExecuteQuery("select * from Record where CheckInTime>='" + startWeek + "' and CheckOutTime<='" + dt + "'");
            int weekMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                weekMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblWeek.Text += weekMoney.ToString();

            //本月营业额
                //本月月初
            DateTime startMonth = dt.AddDays(1 - dt.Day);
            ds = DBHelper.ExecuteQuery("select * from Record where CheckInTime>='" + startMonth + "' and CheckOutTime<='" + dt + "'");
            int monthMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                monthMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString()); 
            }
            lblMonth.Text += monthMoney.ToString();

            //本年营业额
                //本年年初 
            DateTime startYear = new DateTime(dt.Year, 1, 1);
            ds = DBHelper.ExecuteQuery("select * from Record where CheckInTime>='" + startYear + "' and CheckOutTime<='" + dt + "'");
            int yearMoney = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                yearMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblYear.Text += yearMoney.ToString();

            //总营业额计算
            int allMoney = 0;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                allMoney += int.Parse(dataSet.Tables[0].Rows[i][8].ToString());
            }
            lblAll.Text += allMoney.ToString();

            //设置右下角
            lblPs.Text += dt.ToLongTimeString().ToString() + ")";
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value<dtpStart.Value)
            {
                MessageBox.Show("选择日期有误！");
                dtpEnd.Value = dtpStart.Value;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = "select " + words + " from Record where 1=1 and CheckInTime>='" + dtpStart.Value + "' and CheckOutTime<='" + dtpEnd.Value + "'";
            if (txtUserName.Text.Trim()!=string.Empty)
            {
                sql += "and CustomerName='" + txtUserName.Text.Trim() + "'";
            }
            dataSet = DBHelper.ExecuteQuery(sql);
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
        }

        //导出Excel方法
        private void ExportExcels(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            if (saveDialog.ShowDialog() != DialogResult.OK) { return; }
            saveFileName = saveDialog.FileName;
            //if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            //写入标题
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\宾客访问记录表.xls";
            ExportExcels(fileName, dataGridView1);
        }
    }
}
