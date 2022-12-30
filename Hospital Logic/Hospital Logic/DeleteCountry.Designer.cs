namespace Hospital_Logic
{
    partial class DeleteCountry
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
            this.countryIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(88, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countryIdtxt
            // 
            this.countryIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.countryIdtxt.Location = new System.Drawing.Point(242, 110);
            this.countryIdtxt.Name = "countryIdtxt";
            this.countryIdtxt.Size = new System.Drawing.Size(250, 45);
            this.countryIdtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country ID";
            // 
            // DeleteCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryIdtxt);
            this.Controls.Add(this.button1);
            this.Name = "DeleteCountry";
            this.Text = "DeleteCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countryIdtxt;
        private System.Windows.Forms.Label label1;
    }
}