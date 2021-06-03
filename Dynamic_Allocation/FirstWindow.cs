using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Allocation
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void BFButton_Click(object sender, EventArgs e) //最佳适应
        {
            Memory.FF = false;
            Program.mwindow = new MainWindow();
            Program.mwindow.Text = "最佳适应算法";
            Program.mwindow.ShowDialog();
            System.Diagnostics.Debug.WriteLine("BFB On click");
            System.Diagnostics.Debug.WriteLine("Change to main window");
        }

        private void FFButton_Click(object sender, EventArgs e) //首次适应
        {
            Memory.FF = true;
            Program.mwindow = new MainWindow();
            Program.mwindow.Text = "首次适应算法";
            Program.mwindow.ShowDialog();
            System.Diagnostics.Debug.WriteLine("FFB On click");
            System.Diagnostics.Debug.WriteLine("Change to main window");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
