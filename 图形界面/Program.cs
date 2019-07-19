using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 图形界面
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            
            dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.Parent.Parent.FullName + @"\HotelManage\WEB用户访问\App_Data";
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
