namespace Hospital_Logic
{
    partial class Menu
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
            this.addOccupationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOccupationBtn
            // 
            this.addOccupationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addOccupationBtn.Location = new System.Drawing.Point(63, 30);
            this.addOccupationBtn.Name = "addOccupationBtn";
            this.addOccupationBtn.Size = new System.Drawing.Size(166, 45);
            this.addOccupationBtn.TabIndex = 0;
            this.addOccupationBtn.Text = "Add Occupation";
            this.addOccupationBtn.UseVisualStyleBackColor = true;
            this.addOccupationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 637);
            this.Controls.Add(this.addOccupationBtn);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addOccupationBtn;
    }
}

