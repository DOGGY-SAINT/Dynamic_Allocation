using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Allocation
{
    static class Program
    {
        public static FirstWindow window;
        public static MainWindow mwindow;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            window = new FirstWindow();
            Application.Run(window);
        }
    }
}
