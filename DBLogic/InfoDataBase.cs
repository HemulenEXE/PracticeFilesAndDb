using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExpornInDB.DBLogic
{
    public static class InfoDataBase
    {
        public static readonly string nameDB = "filesdb";
        public static readonly string nameTable = "filestable";
        //public static readonly string createDbCMD = $"CREATE DATABASE {nameDB};";
        public static readonly string checkExistsDbCMD = $"SELECT 1 FROM pg_database WHERE datname = @db";
        public static readonly string createTableCMD = $"CREATE TABLE IF NOT EXISTS {nameTable} (Id SERIAL PRIMARY KEY,nameFile TEXT, formatFile CHARACTER VARYING(10), timeCreate TIMESTAMP, dataFile bytea);";
        public static readonly string addFileCMD = $"INSERT INTO {nameTable} (nameFile, formatFile, timeCreate, dataFile) VALUES(@nameFile,@formatFile,@timeCreate, @dataFile);";
        public static readonly string deleteFileCMD = $"DELETE FROM {nameTable} where Id = @Id;";
        public static readonly string selectFileCMD = $"SELECT * FROM {nameTable} where Id = @Id;";
        public static readonly string selectFilesCMD = $"SELECT * FROM {nameTable}";
        public static readonly string lastId = $"SELECT last_value FROM {nameTable}_id_seq;";
    }
}
