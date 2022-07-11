namespace File_backup_engine
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Project_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backup_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Successfull_backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project_path,
            this.Project_name,
            this.Project_backup,
            this.Backup_date,
            this.Successfull_backup});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // Project_path
            // 
            this.Project_path.HeaderText = "Project Path";
            this.Project_path.Name = "Project_path";
            // 
            // Project_name
            // 
            this.Project_name.HeaderText = "Project Name";
            this.Project_name.Name = "Project_name";
            // 
            // Project_backup
            // 
            this.Project_backup.HeaderText = "Project Backup";
            this.Project_backup.Name = "Project_backup";
            // 
            // Backup_date
            // 
            this.Backup_date.HeaderText = "BackUp Date";
            this.Backup_date.Name = "Backup_date";
            // 
            // Successfull_backup
            // 
            this.Successfull_backup.HeaderText = "Successfull Backup";
            this.Successfull_backup.Name = "Successfull_backup";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 489);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_backup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Backup_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Successfull_backup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

