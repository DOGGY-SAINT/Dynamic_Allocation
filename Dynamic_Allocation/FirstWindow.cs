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
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
            System.Diagnostics.Debug.WriteLine("BFB On click");
            System.Diagnostics.Debug.WriteLine("Change to main window");
        }

        private void FFButton_Click(object sender, EventArgs e) //首次适应
        {
            Memory.FF = true;
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
            System.Diagnostics.Debug.WriteLine("FFB On click");
            System.Diagnostics.Debug.WriteLine("Change to main window");
        }
    }
}
