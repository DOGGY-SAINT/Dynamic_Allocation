
namespace Dynamic_Allocation
{
    partial class MainWindow
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StepButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(2, 30);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 24);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "返回首页";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(2, 2);
            this.StepButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(75, 24);
            this.StepButton.TabIndex = 1;
            this.StepButton.Text = "单步执行";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StepButton);
            this.flowLayoutPanel1.Controls.Add(this.ReturnButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(794, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(83, 62);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.AllowUserToResizeColumns = false;
            this.OrderGridView.AllowUserToResizeRows = false;
            this.OrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Request,
            this.MSize});
            this.OrderGridView.Location = new System.Drawing.Point(9, 38);
            this.OrderGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 51;
            this.OrderGridView.RowTemplate.Height = 27;
            this.OrderGridView.Size = new System.Drawing.Size(338, 335);
            this.OrderGridView.TabIndex = 3;
            // 
            // User
            // 
            this.User.HeaderText = "作业号";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            // 
            // Request
            // 
            this.Request.HeaderText = "请求";
            this.Request.MinimumWidth = 6;
            this.Request.Name = "Request";
            // 
            // MSize
            // 
            this.MSize.HeaderText = "内存大小";
            this.MSize.MinimumWidth = 6;
            this.MSize.Name = "MSize";
            // 
            // MemGridView
            // 
            this.MemGridView.AllowUserToAddRows = false;
            this.MemGridView.AllowUserToDeleteRows = false;
            this.MemGridView.AllowUserToResizeColumns = false;
            this.MemGridView.AllowUserToResizeRows = false;
            this.MemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.MemGridView.Location = new System.Drawing.Point(442, 38);
            this.MemGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemGridView.Name = "MemGridView";
            this.MemGridView.RowHeadersWidth = 51;
            this.MemGridView.RowTemplate.Height = 27;
            this.MemGridView.Size = new System.Drawing.Size(338, 335);
            this.MemGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "起始位置";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "内存大小";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "空闲分区链表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "分配请求表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "内存分配图";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemGridView);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "执行";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSize;
        public System.Windows.Forms.DataGridView MemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}