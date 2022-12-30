namespace Hospital_Logic
{
    partial class AddCity
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
            this.CityExecuteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityNametxt = new System.Windows.Forms.TextBox();
            this.CityIdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CityExecuteBtn
            // 
            this.CityExecuteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.CityExecuteBtn.Location = new System.Drawing.Point(119, 239);
            this.CityExecuteBtn.Name = "CityExecuteBtn";
            this.CityExecuteBtn.Size = new System.Drawing.Size(237, 64);
            this.CityExecuteBtn.TabIndex = 0;
            this.CityExecuteBtn.Text = "Execute";
            this.CityExecuteBtn.UseVisualStyleBackColor = true;
            this.CityExecuteBtn.Click += new System.EventHandler(this.CityExecuteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(72, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "City ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(5, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "City Name";
            // 
            // cityNametxt
            // 
            this.cityNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cityNametxt.Location = new System.Drawing.Point(217, 160);
            this.cityNametxt.Name = "cityNametxt";
            this.cityNametxt.Size = new System.Drawing.Size(244, 38);
            this.cityNametxt.TabIndex = 3;
            // 
            // CityIdtxt
            // 
            this.CityIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CityIdtxt.Location = new System.Drawing.Point(217, 102);
            this.CityIdtxt.Name = "CityIdtxt";
            this.CityIdtxt.Size = new System.Drawing.Size(244, 38);
            this.CityIdtxt.TabIndex = 4;
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.CityIdtxt);
            this.Controls.Add(this.cityNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityExecuteBtn);
            this.Name = "AddCity";
            this.Text = "AddCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CityExecuteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityNametxt;
        private System.Windows.Forms.TextBox CityIdtxt;
    }
}