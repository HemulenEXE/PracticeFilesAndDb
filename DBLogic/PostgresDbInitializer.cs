using ImportExpornInDB.DBLogic.Interface;
using Npgsql;
using PracticeFilesAndDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExpornInDB.DBLogic
{
    internal class PostgresDbInitializer : IDbInitializer
    {
        public void InitDb()
        {
            //EnsureDataBase();
            EnsureTable();
        }
        //private void EnsureDataBase()
        //{
        //    using NpgsqlConnection connDefaultDb = new NpgsqlConnection(ConfigurationManager.AppSettings["defaultStringConnect"])
        //        ?? throw new Exception("Не удалось подключение к стандартной базе!");

        //    if (!DatabaseExists(InfoDataBase.nameDB))
        //    {
        //        using (NpgsqlCommand createDB = new NpgsqlCommand(InfoDataBase.createDbCMD, connDefaultDb))
        //        {
        //            createDB.ExecuteNonQuery();
        //        }
        //    }
        //}
        private  void EnsureTable()
        {
            using NpgsqlConnection mainConn = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect())
                ?? throw new Exception("Не удалось подключение к главной базе!");
            mainConn.Open();
            using (NpgsqlCommand createTable = new NpgsqlCommand(InfoDataBase.createTableCMD, mainConn))
            {
                createTable.ExecuteNonQuery();
            }
        }

        private bool DatabaseExists(string dbName)
        {
            using var adminConn = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
            adminConn.Open();
            using (var checkCmd = new NpgsqlCommand(InfoDataBase.checkExistsDbCMD, adminConn))
            {
                checkCmd.Parameters.AddWithValue("db", dbName);
                var result = checkCmd.ExecuteScalar();
                return result != null;
            }

        }
    }
}
