
namespace Dynamic_Allocation
{
    partial class FirstWindow
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
            this.BFButton = new System.Windows.Forms.Button();
            this.FFButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BFButton
            // 
            this.BFButton.Location = new System.Drawing.Point(77, 103);
            this.BFButton.Name = "BFButton";
            this.BFButton.Size = new System.Drawing.Size(150, 30);
            this.BFButton.TabIndex = 1;
            this.BFButton.Text = "最佳适应算法";
            this.BFButton.UseVisualStyleBackColor = true;
            this.BFButton.Click += new System.EventHandler(this.BFButton_Click);
            // 
            // FFButton
            // 
            this.FFButton.Location = new System.Drawing.Point(329, 103);
            this.FFButton.Name = "FFButton";
            this.FFButton.Size = new System.Drawing.Size(150, 30);
            this.FFButton.TabIndex = 2;
            this.FFButton.Text = "首次适应算法";
            this.FFButton.UseVisualStyleBackColor = true;
            this.FFButton.Click += new System.EventHandler(this.FFButton_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.FFButton);
            this.Controls.Add(this.BFButton);
            this.Name = "FirstWindow";
            this.Text = "选择算法";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BFButton;
        private System.Windows.Forms.Button FFButton;
    }
}