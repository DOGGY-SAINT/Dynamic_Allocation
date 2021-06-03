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
        public Memory Mem;
        public MainWindow()
        {
            InitializeComponent();
            Mem = new Memory();
            Mem.Log();

            for (int i = 0; i < Mem.Ord.Length; i++)
            {
                Order od = Mem.Ord[i];
                this.OrderGridView.Rows.Add(od.User, od.Type, od.Size);

            }
            this.OrderGridView.Rows[0].DefaultCellStyle.BackColor = Color.Red;

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Debug.WriteLine("RB On click");
            System.Diagnostics.Debug.WriteLine("Change to first window");
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            Mem.RunStep();
            Mem.Log();
        }




    }
}
