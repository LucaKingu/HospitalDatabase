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
            this.MedicationBtn = new System.Windows.Forms.Button();
            this.MedicationOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOccupationBtn
            // 
            this.addOccupationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addOccupationBtn.Location = new System.Drawing.Point(26, 12);
            this.addOccupationBtn.Name = "addOccupationBtn";
            this.addOccupationBtn.Size = new System.Drawing.Size(128, 63);
            this.addOccupationBtn.TabIndex = 0;
            this.addOccupationBtn.Text = "Add Occupation";
            this.addOccupationBtn.UseVisualStyleBackColor = true;
            this.addOccupationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddPatientButton.Location = new System.Drawing.Point(26, 81);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(128, 56);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(26, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Health Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HospitalEmployeeButton
            // 
            this.HospitalEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HospitalEmployeeButton.Location = new System.Drawing.Point(12, 343);
            this.HospitalEmployeeButton.Name = "HospitalEmployeeButton";
            this.HospitalEmployeeButton.Size = new System.Drawing.Size(142, 81);
            this.HospitalEmployeeButton.TabIndex = 3;
            this.HospitalEmployeeButton.Text = "Add Hospital Employee";
            this.HospitalEmployeeButton.UseVisualStyleBackColor = true;
            this.HospitalEmployeeButton.Click += new System.EventHandler(this.HospitalEmployeeButton_Click);
            // 
            // DepartmentBtn
            // 
            this.DepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DepartmentBtn.Location = new System.Drawing.Point(26, 430);
            this.DepartmentBtn.Name = "DepartmentBtn";
            this.DepartmentBtn.Size = new System.Drawing.Size(128, 58);
            this.DepartmentBtn.TabIndex = 4;
            this.DepartmentBtn.Text = "Add Department";
            this.DepartmentBtn.UseVisualStyleBackColor = true;
            this.DepartmentBtn.Click += new System.EventHandler(this.DepartmentBtn_Click);
            // 
            // cityBtn
            // 
            this.cityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cityBtn.Location = new System.Drawing.Point(26, 217);
            this.cityBtn.Name = "cityBtn";
            this.cityBtn.Size = new System.Drawing.Size(128, 56);
            this.cityBtn.TabIndex = 5;
            this.cityBtn.Text = "Add City";
            this.cityBtn.UseVisualStyleBackColor = true;
            this.cityBtn.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // countryBtn
            // 
            this.countryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.countryBtn.Location = new System.Drawing.Point(26, 279);
            this.countryBtn.Name = "countryBtn";
            this.countryBtn.Size = new System.Drawing.Size(128, 58);
            this.countryBtn.TabIndex = 6;
            this.countryBtn.Text = "Add Country";
            this.countryBtn.UseVisualStyleBackColor = true;
            this.countryBtn.Click += new System.EventHandler(this.countryBtn_Click);
            // 
            // MedicationBtn
            // 
            this.MedicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MedicationBtn.Location = new System.Drawing.Point(26, 494);
            this.MedicationBtn.Name = "MedicationBtn";
            this.MedicationBtn.Size = new System.Drawing.Size(128, 58);
            this.MedicationBtn.TabIndex = 7;
            this.MedicationBtn.Text = "Add Medication";
            this.MedicationBtn.UseVisualStyleBackColor = true;
            this.MedicationBtn.Click += new System.EventHandler(this.MedicationBtn_Click);
            // 
            // MedicationOrderBtn
            // 
            this.MedicationOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MedicationOrderBtn.Location = new System.Drawing.Point(12, 558);
            this.MedicationOrderBtn.Name = "MedicationOrderBtn";
            this.MedicationOrderBtn.Size = new System.Drawing.Size(168, 67);
            this.MedicationOrderBtn.TabIndex = 8;
            this.MedicationOrderBtn.Text = "Add Medication Order";
            this.MedicationOrderBtn.UseVisualStyleBackColor = true;
            this.MedicationOrderBtn.Click += new System.EventHandler(this.MedicationOrderBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 637);
            this.Controls.Add(this.MedicationOrderBtn);
            this.Controls.Add(this.MedicationBtn);
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
        private System.Windows.Forms.Button MedicationBtn;
        private System.Windows.Forms.Button MedicationOrderBtn;
    }
}

