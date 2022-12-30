namespace Hospital_Logic
{
    partial class DeleteDepartment
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
            this.DepartmentIdtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(98, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartmentIdtxt
            // 
            this.DepartmentIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DepartmentIdtxt.Location = new System.Drawing.Point(256, 93);
            this.DepartmentIdtxt.Name = "DepartmentIdtxt";
            this.DepartmentIdtxt.Size = new System.Drawing.Size(218, 45);
            this.DepartmentIdtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department ID";
            // 
            // DeleteDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentIdtxt);
            this.Controls.Add(this.button1);
            this.Name = "DeleteDepartment";
            this.Text = "DeleteDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DepartmentIdtxt;
        private System.Windows.Forms.Label label1;
    }
}