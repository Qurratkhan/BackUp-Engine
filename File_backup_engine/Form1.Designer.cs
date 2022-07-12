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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addBackup = new System.Windows.Forms.PictureBox();
            this.pic_addbackup = new System.Windows.Forms.PictureBox();
            this.Project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backup_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackUp_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rollback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addbackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rollback)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project_name,
            this.Project_path,
            this.Backup_date,
            this.BackUp_path,
            this.IsBackup});
            this.dataGridView1.Location = new System.Drawing.Point(4, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1155, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 602);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.53579F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.462817F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.101972F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.899683F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999732F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addBackup, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pic_addbackup, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_rollback, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1155, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(911, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addBackup
            // 
            this.addBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBackup.BackgroundImage")));
            this.addBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBackup.Location = new System.Drawing.Point(974, 4);
            this.addBackup.Margin = new System.Windows.Forms.Padding(4);
            this.addBackup.Name = "addBackup";
            this.addBackup.Size = new System.Drawing.Size(50, 104);
            this.addBackup.TabIndex = 1;
            this.addBackup.TabStop = false;
            this.addBackup.Click += new System.EventHandler(this.addBackup_Click);
            // 
            // pic_addbackup
            // 
            this.pic_addbackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_addbackup.BackgroundImage")));
            this.pic_addbackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_addbackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_addbackup.Location = new System.Drawing.Point(1031, 3);
            this.pic_addbackup.Name = "pic_addbackup";
            this.pic_addbackup.Size = new System.Drawing.Size(62, 106);
            this.pic_addbackup.TabIndex = 2;
            this.pic_addbackup.TabStop = false;
            this.pic_addbackup.Click += new System.EventHandler(this.pic_addbackup_Click);
            // 
            // Project_name
            // 
            this.Project_name.HeaderText = "Project Name";
            this.Project_name.MinimumWidth = 6;
            this.Project_name.Name = "Project_name";
            this.Project_name.Width = 125;
            // 
            // Project_path
            // 
            this.Project_path.HeaderText = "Project Path";
            this.Project_path.MinimumWidth = 6;
            this.Project_path.Name = "Project_path";
            this.Project_path.Width = 125;
            // 
            // Backup_date
            // 
            this.Backup_date.HeaderText = "BackUp Date";
            this.Backup_date.MinimumWidth = 6;
            this.Backup_date.Name = "Backup_date";
            this.Backup_date.Width = 125;
            // 
            // BackUp_path
            // 
            this.BackUp_path.HeaderText = "Backup Path";
            this.BackUp_path.MinimumWidth = 6;
            this.BackUp_path.Name = "BackUp_path";
            this.BackUp_path.Width = 125;
            // 
            // IsBackup
            // 
            this.IsBackup.HeaderText = "IsBackUp";
            this.IsBackup.MinimumWidth = 6;
            this.IsBackup.Name = "IsBackup";
            this.IsBackup.Width = 125;
            // 
            // btn_rollback
            // 
            this.btn_rollback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rollback.BackgroundImage")));
            this.btn_rollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rollback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rollback.Location = new System.Drawing.Point(1099, 3);
            this.btn_rollback.Name = "btn_rollback";
            this.btn_rollback.Size = new System.Drawing.Size(53, 106);
            this.btn_rollback.TabIndex = 3;
            this.btn_rollback.TabStop = false;
            this.btn_rollback.Click += new System.EventHandler(this.btn_rollback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addbackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rollback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox addBackup;
        private System.Windows.Forms.PictureBox pic_addbackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Backup_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackUp_path;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBackup;
        private System.Windows.Forms.PictureBox btn_rollback;
    }
}

