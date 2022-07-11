using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_backup_engine
{
    public class ValueEventHandle :EventArgs
    {
        private string _path;
        private string _project;
        private string _backup;
        public ValueEventHandle(string path , string project , string backup)
        {
            this._path = path;
            this._project = project;
            this._backup = backup;
        }
        public string get_path
        {
            get { return _path; }
        }

        public string get_project
        {
            get { return _project; }
        }
        public string get_backup
        {
            get { return _backup; }
        }
    }
}
