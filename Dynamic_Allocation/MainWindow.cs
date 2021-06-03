using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Dynamic_Allocation
{
    public partial class MainWindow : Form
    {
        public Memory Mem;
        public ArrayList Labels;
        public System.Drawing.Point dlocation;
        public int labh;    //高度
        public int labw;    //总长
        public MainWindow()
        {
            InitializeComponent();
            this.Mem = new Memory();
            this.Mem.Log();
            this.dlocation = new System.Drawing.Point(50, 450);
            this.labh = 50;
            this.labw = 800;
            this.Labels = new ArrayList();
            for (int i = 0; i < Mem.Ord.Length; i++)
            {
                Order od = Mem.Ord[i];
                this.OrderGridView.Rows.Add(od.User, od.Type, od.Size);
            }
            this.UpdateWin();    //展示指令，内存
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
        public void UpdateWin()     //更新窗口
        {
            if (Mem.Index < Mem.Ord.Length)     //指令标红
                this.OrderGridView.Rows[Mem.Index].DefaultCellStyle.BackColor = Color.Red;
            foreach (Label lb in Labels)     //移除之前的内存图
            {
                this.Controls.Remove(lb);
            }
            this.MemGridView.Rows.Clear();  //清空
            Node A = this.Mem.UnUsed.Head.Next;
            while (A != null)
            {
                this.CreateLabel(A);        //未用内存图
                this.MemGridView.Rows.Add(A.Data.Begin, A.Data.Size);        //空闲内存表
                A = A.Next;
            }
            A = this.Mem.Used.Head.Next;     //已用内存图
            while (A != null)
            {
                this.CreateLabel(A, false);
                A = A.Next;
            }

        }

        void CreateLabel(Node node, bool unu = true)
        {
            Label label = new Label();      //中间的字
            label.Height = this.labh;
            label.Width = (int)(this.labw * ((double)node.Data.Size / this.Mem.AllSize));
            label.Location = new System.Drawing.Point((int)(this.dlocation.X + this.labw * ((double)node.Data.Begin / this.Mem.AllSize)), this.dlocation.Y);
            label.Text = node.Data.Size + "K";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BorderStyle = BorderStyle.FixedSingle;
            if (!unu)   //使用
            {
                label.BackColor = Color.Red;
                label.Text = "作业" + node.Data.User + " " + label.Text;
            }
            else
            {
                label.BackColor = Color.White;
            }
            Label lb2 = new Label();    //上方的字
            lb2.Height = 15;
            lb2.Width = 30;
            lb2.Location= new System.Drawing.Point(label.Location.X-15, this.dlocation.Y- lb2.Height);
            lb2.Text = node.Data.Begin + "K";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lb2);
            this.Labels.Add(lb2);
            this.Controls.Add(label);
            this.Labels.Add(label);
        }

    }
}
