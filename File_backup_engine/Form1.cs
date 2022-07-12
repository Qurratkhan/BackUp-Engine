using File_backup_engine.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static File_backup_engine.AddProject;

namespace File_backup_engine
{
    public partial class Form1 : Form
    {

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataAdapter sda;
        public Form1()
        {
            InitializeComponent();         
            // Initialize basic DataGridView properties.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            
            sqlite_conn = Connection.CreateConnection();
           
            loadGridView(sqlite_conn);
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

                        AddProject addPro = new AddProject(project_path , folder_name);
                        addPro.Show();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void loadGridView(SQLiteConnection sql_conn)
        {
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.ForeColor = Color.Black;

            dataGridView1.Font = new Font("Arial", 10);

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM project";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //string myreader = sqlite_datareader.GetString(0);

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = sqlite_datareader.GetString(1);
                row.Cells[1].Value = sqlite_datareader.GetString(4);
                row.Cells[2].Value = sqlite_datareader.GetString(2);
                row.Cells[3].Value = sqlite_datareader.GetString(5); 
                row.Cells[4].Value = sqlite_datareader.GetInt16(3);

                dataGridView1.Rows.Add(row);
            }
            //CheckBox checkBox = new CheckBox();
            
        }

        private void addBackup_Click(object sender, EventArgs e)
        {
            BackUp backUp = new BackUp();
            backUp.Show();
        }

        private void pic_addbackup_Click(object sender, EventArgs e)
        {

            sqlite_conn = Connection.CreateConnection();
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM project where isbackup = 1";
            sda = new SQLiteDataAdapter(sqlite_cmd.CommandText, sqlite_conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                //MessageBox.Show("You selected: " + chk.Text);
                string startPath = @"" + row["projectPath"].ToString(); ;
                string zipPath = @"C:\Users\Annie\Desktop\Desktop\Backup\" + row["projectName"] + "_" + DateTime.Today.ToLongDateString() + ".zip";
                string extractPath = @"C:\Users\Annie\Desktop\Desktop\RollBack\" + row["projectName"] + "_" + DateTime.Today.ToLongDateString() + ".zip";


                ZipFile.CreateFromDirectory(startPath, zipPath);
                //ZipFile.ExtractToDirectory(zipPath, extractPath);

                sqlite_conn = Connection.CreateConnection();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                DateTime now = DateTime.Now;

                sqlite_cmd.CommandText = "INSERT INTO backup(projectName, backupPath , backupDate , success) VALUES(@proName , @backup ,@proDate , @s)";
                sqlite_cmd.Parameters.AddWithValue("@proName", row["projectName"]);
                sqlite_cmd.Parameters.AddWithValue("@backup", zipPath);
                sqlite_cmd.Parameters.AddWithValue("@proDate", DateTime.Now);
                sqlite_cmd.Parameters.AddWithValue("@s", 1);

                int i = sqlite_cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Backup done successfully" , "Congratulations..", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.Hide();


            }

            }

        private void btn_rollback_Click(object sender, EventArgs e)
        {
            sqlite_conn = Connection.CreateConnection();
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM project where isbackup = 1";
            sda = new SQLiteDataAdapter(sqlite_cmd.CommandText, sqlite_conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                // string zipPath = @"C:\Users\Annie\Desktop\Desktop\Backup\" + row["projectName"] + "_" + DateTime.Today.ToLongDateString() + ".zip";
                string zipPath = row["projectBackup"].ToString();
                string extractPath = @"C:\Users\Annie\Desktop\Desktop\Rollback\" + row["projectName"] + "_" + DateTime.Today.ToLongDateString() + ".zip";
               
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                sqlite_conn = Connection.CreateConnection();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                DateTime now = DateTime.Now;

                sqlite_cmd.CommandText = "INSERT INTO rollback(projectName, rollbackPath , rollbackDate , success) VALUES(@proName , @rollback ,@proDate , @s)";
                sqlite_cmd.Parameters.AddWithValue("@proName", row["projectPath"]);
                sqlite_cmd.Parameters.AddWithValue("@rollback", zipPath);
                sqlite_cmd.Parameters.AddWithValue("@proDate", DateTime.Now);
                sqlite_cmd.Parameters.AddWithValue("@s", 0);

                int i = sqlite_cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Rollback done successfully", "Congratulations..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();


            }

        }
    }
}
