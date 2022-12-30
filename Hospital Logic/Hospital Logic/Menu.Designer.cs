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
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HospitalEmployeeButton = new System.Windows.Forms.Button();
            this.DepartmentBtn = new System.Windows.Forms.Button();
            this.cityBtn = new System.Windows.Forms.Button();
            this.countryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOccupationBtn
            // 
            this.addOccupationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addOccupationBtn.Location = new System.Drawing.Point(26, 21);
            this.addOccupationBtn.Name = "addOccupationBtn";
            this.addOccupationBtn.Size = new System.Drawing.Size(166, 58);
            this.addOccupationBtn.TabIndex = 0;
            this.addOccupationBtn.Text = "Add Occupation";
            this.addOccupationBtn.UseVisualStyleBackColor = true;
            this.addOccupationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddPatientButton.Location = new System.Drawing.Point(26, 104);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(166, 58);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(26, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Health Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HospitalEmployeeButton
            // 
            this.HospitalEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HospitalEmployeeButton.Location = new System.Drawing.Point(26, 463);
            this.HospitalEmployeeButton.Name = "HospitalEmployeeButton";
            this.HospitalEmployeeButton.Size = new System.Drawing.Size(166, 58);
            this.HospitalEmployeeButton.TabIndex = 3;
            this.HospitalEmployeeButton.Text = "Add Hospital Employee";
            this.HospitalEmployeeButton.UseVisualStyleBackColor = true;
            this.HospitalEmployeeButton.Click += new System.EventHandler(this.HospitalEmployeeButton_Click);
            // 
            // DepartmentBtn
            // 
            this.DepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DepartmentBtn.Location = new System.Drawing.Point(26, 567);
            this.DepartmentBtn.Name = "DepartmentBtn";
            this.DepartmentBtn.Size = new System.Drawing.Size(166, 58);
            this.DepartmentBtn.TabIndex = 4;
            this.DepartmentBtn.Text = "Add Department";
            this.DepartmentBtn.UseVisualStyleBackColor = true;
            this.DepartmentBtn.Click += new System.EventHandler(this.DepartmentBtn_Click);
            // 
            // cityBtn
            // 
            this.cityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cityBtn.Location = new System.Drawing.Point(26, 275);
            this.cityBtn.Name = "cityBtn";
            this.cityBtn.Size = new System.Drawing.Size(166, 58);
            this.cityBtn.TabIndex = 5;
            this.cityBtn.Text = "Add City";
            this.cityBtn.UseVisualStyleBackColor = true;
            this.cityBtn.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // countryBtn
            // 
            this.countryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.countryBtn.Location = new System.Drawing.Point(26, 367);
            this.countryBtn.Name = "countryBtn";
            this.countryBtn.Size = new System.Drawing.Size(166, 58);
            this.countryBtn.TabIndex = 6;
            this.countryBtn.Text = "Add Country";
            this.countryBtn.UseVisualStyleBackColor = true;
            this.countryBtn.Click += new System.EventHandler(this.countryBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 637);
            this.Controls.Add(this.countryBtn);
            this.Controls.Add(this.cityBtn);
            this.Controls.Add(this.DepartmentBtn);
            this.Controls.Add(this.HospitalEmployeeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.addOccupationBtn);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addOccupationBtn;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HospitalEmployeeButton;
        private System.Windows.Forms.Button DepartmentBtn;
        private System.Windows.Forms.Button cityBtn;
        private System.Windows.Forms.Button countryBtn;
    }
}

