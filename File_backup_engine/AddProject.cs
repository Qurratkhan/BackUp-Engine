using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using File_backup_engine.Data;

namespace File_backup_engine
{
   
    public partial class AddProject : Form
    {
        public string pro_path;
        public string folder_name;
        SQLiteConnection sqlite_conn;
        public AddProject()
        {

        }

        public AddProject(string path, string folder)
        {
            InitializeComponent();

            this.pro_path = path;
            this.folder_name = folder;
            txtProPath.ReadOnly = true;
            txtProName.ReadOnly = true;
            txtProBackupPath.ReadOnly = true;

            txtProName.Text = folder_name;
            txtProPath.Text = pro_path;

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            sqlite_conn = Connection.CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            DateTime now = DateTime.Now;

            string path = txtProBackupPath.Text + "'\'" + txtProName.Text + "_" + DateTime.Today.ToLongDateString() + ".zip";

            sqlite_cmd.CommandText = "INSERT INTO project(projectName, projectDate , projectPath , projectBackup) VALUES(@proName,@proDate , @proPath , @proBack)";
            sqlite_cmd.Parameters.AddWithValue("@proName", folder_name) ;
            sqlite_cmd.Parameters.AddWithValue("@proDate", now);
            sqlite_cmd.Parameters.AddWithValue("@proPath", txtProPath.Text);
            sqlite_cmd.Parameters.AddWithValue("@proBack", path);

            int i = sqlite_cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Project added successfully", "Congratulations..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f1 = new Form1();
                f1.loadGridView(sqlite_conn);
            }
        }

        private void btnOPenBackup_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string project_path = fbd.SelectedPath;
                        txtProBackupPath.Text = project_path;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlite_conn = Connection.CreateConnection();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM project", sqlite_conn);
            //SQLiteCommand cmd = new SQLiteCommand("Alter table project add projectBackup varchar(200)", sqlite_conn);
            cmd.ExecuteNonQuery(); 

        }
    }
}
