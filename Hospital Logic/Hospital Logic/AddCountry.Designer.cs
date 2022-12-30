namespace Hospital_Logic
{
    partial class AddCountry
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
            this.CountryExecBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountryIdtxt = new System.Windows.Forms.TextBox();
            this.countryNametxt = new System.Windows.Forms.TextBox();
            this.riskOfForeignDiseasetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CountryExecBtn
            // 
            this.CountryExecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.CountryExecBtn.Location = new System.Drawing.Point(134, 212);
            this.CountryExecBtn.Name = "CountryExecBtn";
            this.CountryExecBtn.Size = new System.Drawing.Size(188, 72);
            this.CountryExecBtn.TabIndex = 0;
            this.CountryExecBtn.Text = "Execute";
            this.CountryExecBtn.UseVisualStyleBackColor = true;
            this.CountryExecBtn.Click += new System.EventHandler(this.CountryExecBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(129, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(96, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Risk Of Foreign Disease";
            // 
            // CountryIdtxt
            // 
            this.CountryIdtxt.Location = new System.Drawing.Point(243, 53);
            this.CountryIdtxt.Name = "CountryIdtxt";
            this.CountryIdtxt.Size = new System.Drawing.Size(215, 20);
            this.CountryIdtxt.TabIndex = 4;
            // 
            // countryNametxt
            // 
            this.countryNametxt.Location = new System.Drawing.Point(243, 104);
            this.countryNametxt.Name = "countryNametxt";
            this.countryNametxt.Size = new System.Drawing.Size(215, 20);
            this.countryNametxt.TabIndex = 5;
            // 
            // riskOfForeignDiseasetxt
            // 
            this.riskOfForeignDiseasetxt.Location = new System.Drawing.Point(243, 152);
            this.riskOfForeignDiseasetxt.Name = "riskOfForeignDiseasetxt";
            this.riskOfForeignDiseasetxt.Size = new System.Drawing.Size(215, 20);
            this.riskOfForeignDiseasetxt.TabIndex = 6;
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 330);
            this.Controls.Add(this.riskOfForeignDiseasetxt);
            this.Controls.Add(this.countryNametxt);
            this.Controls.Add(this.CountryIdtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryExecBtn);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CountryExecBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CountryIdtxt;
        private System.Windows.Forms.TextBox countryNametxt;
        private System.Windows.Forms.TextBox riskOfForeignDiseasetxt;
    }
}