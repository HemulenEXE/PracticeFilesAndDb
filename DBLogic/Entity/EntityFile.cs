using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PracticeFilesAndDB.DBLogic.Entity
{
    public class EntityFile
    {
        public int id;
        public string name;
        public string formatFile;
        public DateTime dateCreate;
        public byte[] dataFile;

        public EntityFile(int id, string name, string formatFile, DateTime dateCreate, byte[] dataFile)
        {
            this.id = id;
            this.name = name;
            this.formatFile = formatFile;
            this.dateCreate = dateCreate;
            this.dataFile = dataFile;
        }
    }
}
