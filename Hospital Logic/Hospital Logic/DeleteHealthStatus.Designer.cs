namespace Hospital_Logic
{
    partial class DeleteHealthStatus
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
            this.healthStatusIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button1.Location = new System.Drawing.Point(47, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // healthStatusIdtxt
            // 
            this.healthStatusIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.healthStatusIdtxt.Location = new System.Drawing.Point(185, 77);
            this.healthStatusIdtxt.Name = "healthStatusIdtxt";
            this.healthStatusIdtxt.Size = new System.Drawing.Size(254, 45);
            this.healthStatusIdtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient ID";
            // 
            // DeleteHealthStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthStatusIdtxt);
            this.Controls.Add(this.button1);
            this.Name = "DeleteHealthStatus";
            this.Text = "DeleteHealthStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox healthStatusIdtxt;
        private System.Windows.Forms.Label label1;
    }
}