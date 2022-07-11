using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static File_backup_engine.AddProject;

namespace File_backup_engine
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
           
            // Initialize basic DataGridView properties.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //loadGridView();

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();         

        }


        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=Database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE project(id integer primary key autoincrement, projectName varchar(100) , projectDate date , isbackup int default 0)";
            string Createsql1 = "CREATE TABLE backup(id integer primary key autoincrement , projectName varchar(100) , backupPath varchar(250), backupDate date, success int default 0)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        string project_path = fbd.SelectedPath;
                        string folder_name = Path.GetFileName(fbd.SelectedPath);

                        AddProject addPro = new AddProject(project_path, folder_name);
                        addPro.updateGrid += new UpdateGridView(loadGridView);
                        addPro.Show();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }


        public void loadGridView(object sender, ValueEventHandle e)
        {
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.ForeColor = Color.Black;

            dataGridView1.Font = new Font("Arial", 10);

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = e.get_project;
                row.Cells[1].Value = e.get_path;
                row.Cells[2].Value = e.get_backup;
                row.Cells[3].Value = DateTime.Now;
                row.Cells[4].Value = 0;

            dataGridView1.Rows.Add(row);
        }

    }
}
