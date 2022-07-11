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

namespace File_backup_engine
{
   
    public partial class AddProject : Form
    {
        public string pro_path;
        public string folder_name;

        public static string ProjectName = "";
        public static string ProjectPath = "";
        public static string ProjectBackupPath = "";
        public static string ProjectDate = "";

        public delegate void UpdateGridView(object sender, ValueEventHandle e);
        public event UpdateGridView updateGrid;


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

            
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=Database.db; Version = 3; New = True; Compress = True; ");
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            DateTime now = DateTime.Now;
            
            sqlite_cmd.CommandText = "INSERT INTO project(projectName, projectDate) VALUES(@proName,@proDate)";
            sqlite_cmd.Parameters.AddWithValue("@proName", folder_name) ;
            sqlite_cmd.Parameters.AddWithValue("@proDate", now);

            int i = sqlite_cmd.ExecuteNonQuery();
            if (i > 0)
            {

                ValueEventHandle args = new ValueEventHandle(folder_name , pro_path , txtProBackupPath.Text);
                updateGrid(this, args);
                this.Close();
                
             
                this.Hide();
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
    }
}
