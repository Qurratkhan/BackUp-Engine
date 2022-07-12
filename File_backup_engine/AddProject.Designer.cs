namespace File_backup_engine
{
    partial class AddProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProPath = new System.Windows.Forms.TextBox();
            this.txtProBackupPath = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnOPenBackup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project BackUp Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Path";
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(355, 73);
            this.txtProName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(469, 34);
            this.txtProName.TabIndex = 3;
            // 
            // txtProPath
            // 
            this.txtProPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPath.Location = new System.Drawing.Point(355, 142);
            this.txtProPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProPath.Multiline = true;
            this.txtProPath.Name = "txtProPath";
            this.txtProPath.Size = new System.Drawing.Size(469, 34);
            this.txtProPath.TabIndex = 4;
            // 
            // txtProBackupPath
            // 
            this.txtProBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProBackupPath.Location = new System.Drawing.Point(355, 214);
            this.txtProBackupPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProBackupPath.Multiline = true;
            this.txtProBackupPath.Name = "txtProBackupPath";
            this.txtProBackupPath.Size = new System.Drawing.Size(469, 34);
            this.txtProBackupPath.TabIndex = 5;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(448, 326);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(179, 59);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnOPenBackup
            // 
            this.btnOPenBackup.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnOPenBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPenBackup.Location = new System.Drawing.Point(833, 215);
            this.btnOPenBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOPenBackup.Name = "btnOPenBackup";
            this.btnOPenBackup.Size = new System.Drawing.Size(40, 32);
            this.btnOPenBackup.TabIndex = 7;
            this.btnOPenBackup.Text = "...";
            this.btnOPenBackup.UseVisualStyleBackColor = true;
            this.btnOPenBackup.Click += new System.EventHandler(this.btnOPenBackup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete All Projects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOPenBackup);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.txtProBackupPath);
            this.Controls.Add(this.txtProPath);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProPath;
        private System.Windows.Forms.TextBox txtProBackupPath;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnOPenBackup;
        private System.Windows.Forms.Button button1;
    }
}