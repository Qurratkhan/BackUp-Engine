using File_backup_engine.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace File_backup_engine
{
    public partial class BackUp : Form
    {
        SQLiteConnection sql_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataAdapter sda;
        public BackUp()
        {
            InitializeComponent();
            CreateCheckbox();
        }

        public void CreateCheckbox()
        {
            sql_conn = Connection.CreateConnection();
            sqlite_cmd = sql_conn.CreateCommand();           
            
            sqlite_cmd.CommandText = "SELECT * FROM project";
            sda = new SQLiteDataAdapter(sqlite_cmd.CommandText, sql_conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = 1;
            int pointa = 50 , pointb = 50;
                foreach (DataRow row in dt.Rows)
                {

                        CheckBox chk = new CheckBox();
                        chk.Name = "check" + i;
                        chk.Width = 150;
                        chk.Location = new Point(pointa, pointb);
                        chk.Text = row["projectName"].ToString();

                            if (int.Parse(row["isbackup"].ToString()) == 1)
                            {
                                chk.Checked = true;
                                chk.CheckedChanged += new EventHandler(CheckBox_Checked);                               
                            }
                            else if(chk.Checked == false)
                            {
                                chk.CheckedChanged += new EventHandler(CheckBox_unChecked);
                            }
                            else if(chk.Checked == true)
                            {
                                chk.CheckedChanged += new EventHandler(CheckBox_Checked);
                            }
                        panel1.Controls.Add(chk);
                        i++;

                        pointb = pointb + 30;
                    
                }
        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox chk = (sender as CheckBox);
            if (chk.Checked)
            {
                sql_conn = Connection.CreateConnection();
                sqlite_cmd = sql_conn.CreateCommand();

                
                sqlite_cmd.CommandText = "UPDATE project set isbackup = 1 where projectName = '" + chk.Text + "'";
                sqlite_cmd.ExecuteNonQuery();           

            }
        }

        private void CheckBox_unChecked(object sender, EventArgs e)
        {
            CheckBox chk = (sender as CheckBox);
            if (chk.Checked)
            {
                sql_conn = Connection.CreateConnection();
                sqlite_cmd = sql_conn.CreateCommand();


                sqlite_cmd.CommandText = "UPDATE project set isbackup = 0 where projectName = '" + chk.Text + "'";
                sqlite_cmd.ExecuteNonQuery();

            }
        }
    }
}
