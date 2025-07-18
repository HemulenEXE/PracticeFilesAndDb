using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;
using System.Data;
using ImportExpornInDB.DBLogic.Interface;
using PracticeFilesAndDB.DBLogic.Entity;
using PracticeFilesAndDB;

namespace ImportExpornInDB.DBLogic
{
    public class PostgresFileRepository : IFileRepository
    {
        public PostgresFileRepository() { }
        

        public void AddFile(EntityFile entityFile)
        {
            try 
            {
                using var _connection = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
                _connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(InfoDataBase.addFileCMD, _connection))
                {
                    cmd.Parameters.AddWithValue("nameFile", entityFile.name);
                    cmd.Parameters.AddWithValue("formatFile", entityFile.formatFile);
                    cmd.Parameters.AddWithValue("timeCreate", entityFile.dateCreate);
                    cmd.Parameters.AddWithValue("dataFile", entityFile.dataFile);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Ошибка Postgres: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения команды: {ex.Message}");
            }
        }
        public void DeleteFile(int id)
        {
            try
            {
                using var _connection = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
                _connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(InfoDataBase.deleteFileCMD, _connection))
                {
                    cmd.Parameters.AddWithValue("Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Ошибка Postgres: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения команды: {ex.Message}");
            }
        }
        public EntityFile GetFile(int id)
        {
            EntityFile entityFile = null;
            using var _connection = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
            _connection.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand(InfoDataBase.selectFileCMD, _connection))
            {
                cmd.Parameters.AddWithValue("Id", id);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var name = reader.GetString(reader.GetOrdinal("namefile"));
                    var format = reader.GetString(reader.GetOrdinal("formatfile"));
                    var time = reader.GetDateTime(reader.GetOrdinal("timecreate"));
                    var data = (byte[])reader["datafile"];
                    reader.Close();
                    entityFile = new EntityFile(id, name, format, time, data);
                }
            }

            return entityFile;
        }
        public List<EntityFile> GetFiles()
        {
            List<EntityFile> result = new List<EntityFile>();

            try
            {
                using var _connection = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
                _connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(InfoDataBase.selectFilesCMD, _connection))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var id = reader.GetInt32(reader.GetOrdinal("id"));
                        var name = reader.GetString(reader.GetOrdinal("namefile"));
                        var format = reader.GetString(reader.GetOrdinal("formatfile"));
                        var time = reader.GetDateTime(reader.GetOrdinal("timecreate"));
                        var data = (byte[])reader["datafile"];

                        result.Add(new EntityFile(id, name, format, time, data));
                    }

                    reader.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Ошибка Postgres: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения команды: {ex.Message}");
            }

            return result;
        }

        public int NextId()
        {
            try
            {
                using var _connection = new NpgsqlConnection(ConnectionSettingsManager.GetStringConnect());
                _connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(InfoDataBase.lastId, _connection))
                {
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Ошибка Postgres: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения команды: {ex.Message}");
            }
            return -1;
        }
    }
}
