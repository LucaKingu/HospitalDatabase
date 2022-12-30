namespace Hospital_Logic
{
    partial class AddDepartment
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
            this.Execute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depNametxt = new System.Windows.Forms.TextBox();
            this.depIdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Execute.Location = new System.Drawing.Point(126, 211);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(199, 69);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(43, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(-1, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // depNametxt
            // 
            this.depNametxt.Location = new System.Drawing.Point(287, 158);
            this.depNametxt.Name = "depNametxt";
            this.depNametxt.Size = new System.Drawing.Size(174, 20);
            this.depNametxt.TabIndex = 3;
            // 
            // depIdtxt
            // 
            this.depIdtxt.Location = new System.Drawing.Point(287, 96);
            this.depIdtxt.Name = "depIdtxt";
            this.depIdtxt.Size = new System.Drawing.Size(174, 20);
            this.depIdtxt.TabIndex = 4;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.depIdtxt);
            this.Controls.Add(this.depNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Execute);
            this.Name = "AddDepartment";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depNametxt;
        private System.Windows.Forms.TextBox depIdtxt;
    }
}