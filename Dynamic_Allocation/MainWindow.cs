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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Program.window.Show();
            this.Close();
            System.Diagnostics.Debug.WriteLine("RB On click");
            System.Diagnostics.Debug.WriteLine("Change to first window");
        }

        private void StepButton_Click(object sender, EventArgs e)
        {

        }
    }
}
