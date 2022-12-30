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
            this.button1 = new System.Windows.Forms.Button();
            this.oIdtxt = new System.Windows.Forms.TextBox();
            this.orderNametxt = new System.Windows.Forms.TextBox();
            this.orderIdtxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(128, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oIdtxt
            // 
            this.oIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.oIdtxt.Location = new System.Drawing.Point(282, 107);
            this.oIdtxt.Name = "oIdtxt";
            this.oIdtxt.Size = new System.Drawing.Size(187, 30);
            this.oIdtxt.TabIndex = 1;
            // 
            // orderNametxt
            // 
            this.orderNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.orderNametxt.Location = new System.Drawing.Point(282, 153);
            this.orderNametxt.Name = "orderNametxt";
            this.orderNametxt.Size = new System.Drawing.Size(187, 30);
            this.orderNametxt.TabIndex = 2;
            // 
            // orderIdtxt
            // 
            this.orderIdtxt.AutoSize = true;
            this.orderIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.orderIdtxt.Location = new System.Drawing.Point(79, 107);
            this.orderIdtxt.Name = "orderIdtxt";
            this.orderIdtxt.Size = new System.Drawing.Size(171, 46);
            this.orderIdtxt.TabIndex = 3;
            this.orderIdtxt.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIdtxt);
            this.Controls.Add(this.orderNametxt);
            this.Controls.Add(this.oIdtxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oIdtxt;
        private System.Windows.Forms.TextBox orderNametxt;
        private System.Windows.Forms.Label orderIdtxt;
        private System.Windows.Forms.Label label2;
    }
}

