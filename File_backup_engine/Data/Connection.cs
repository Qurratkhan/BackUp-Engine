using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_backup_engine.Data
{
    public class Connection
    {
        public static SQLiteConnection CreateConnection()
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
                Console.WriteLine(ex.Message);
            }
            return sqlite_conn;
        }


        public static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;

            string Createsql = "CREATE TABLE if not exists project(id integer primary key autoincrement, projectName varchar(100) , projectDate date , isbackup int default 0 , projectPath varchar(200))";
            string Createsql1 = "CREATE TABLE if not exists backup(id integer primary key autoincrement , projectName varchar(100) , backupPath varchar(250), backupDate date, success int default 0)";
            string Createsql2 = "CREATE TABLE if not exists rollback(id integer primary key autoincrement , projectName varchar(100) , rollbackPath varchar(250), rollbackDate date, success int default 0)";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql2;
            sqlite_cmd.ExecuteNonQuery();

        }


    }
}
