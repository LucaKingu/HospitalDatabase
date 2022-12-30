namespace Hospital_Logic
{
    partial class AddOccupation
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
            this.occupantExecBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderIdtxt = new System.Windows.Forms.TextBox();
            this.OrderNametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // occupantExecBtn
            // 
            this.occupantExecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.occupantExecBtn.Location = new System.Drawing.Point(114, 268);
            this.occupantExecBtn.Name = "occupantExecBtn";
            this.occupantExecBtn.Size = new System.Drawing.Size(295, 74);
            this.occupantExecBtn.TabIndex = 0;
            this.occupantExecBtn.Text = "Execute";
            this.occupantExecBtn.UseVisualStyleBackColor = true;
            this.occupantExecBtn.Click += new System.EventHandler(this.occupantExecBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(56, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Name";
            // 
            // OrderIdtxt
            // 
            this.OrderIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderIdtxt.Location = new System.Drawing.Point(186, 122);
            this.OrderIdtxt.Name = "OrderIdtxt";
            this.OrderIdtxt.Size = new System.Drawing.Size(223, 38);
            this.OrderIdtxt.TabIndex = 3;
            // 
            // OrderNametxt
            // 
            this.OrderNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderNametxt.Location = new System.Drawing.Point(186, 183);
            this.OrderNametxt.Name = "OrderNametxt";
            this.OrderNametxt.Size = new System.Drawing.Size(223, 38);
            this.OrderNametxt.TabIndex = 4;
            // 
            // AddOccupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 399);
            this.Controls.Add(this.OrderNametxt);
            this.Controls.Add(this.OrderIdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.occupantExecBtn);
            this.Name = "AddOccupation";
            this.Text = "AddOccupation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button occupantExecBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderIdtxt;
        private System.Windows.Forms.TextBox OrderNametxt;
    }
}