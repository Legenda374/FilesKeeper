using FilesKeeper.DataBase.Interface;
using FilesKeeper.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace FilesKeeper.DataBase.Providers
{
    public class SQLiteProvider : IDBProvider, IDisposable
    {
        SQLiteConnection DBConnection;

        public SQLiteProvider(string connectionString)
        {
            DBConnection = new SQLiteConnection(connectionString);
            if (!_ExistFilesTable())
                _CreateFilesTable();
           
        }

        public async Task<FileModel[]> GetListFiles()
        {

            try
            {
                List<FileModel> files = new List<FileModel>();

                DBConnection.Open();

                SQLiteCommand Command = new SQLiteCommand
                {
                    Connection = DBConnection,
                    CommandText = @"SELECT id, name, originalName, extension, compressed, compressedSize, fullSize FROM files"
                };

                var sqlReader = await Command.ExecuteReaderAsync();

                while (sqlReader.Read())
                {
                    files.Add(new FileModel
                    {
                        Id = Convert.ToInt32(sqlReader["id"]),
                        Name = sqlReader["name"].ToString(),
                        OriginalName = sqlReader["originalName"].ToString(),
                        Extension = sqlReader["extension"].ToString(),
                        Compressed = Convert.ToInt32(sqlReader["compressed"]) == 1 ? true : false,
                        CompressedSize = Convert.ToInt64(sqlReader["compressedSize"]),
                        FullSize = Convert.ToInt64(sqlReader["fullSize"])

                    });
                }

                return files.ToArray();
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public async Task<FileModel> SaveFile(string name, string originalName, string extension, bool compressed, long compressedSize, long fullSize, byte[] byteArray)
        {
            try
            {
                DBConnection.Open();

                string commandText = "INSERT INTO [files] ([name], [originalName], [extension], [compressed], [compressedSize], [fullSize], [byteArray]) VALUES(@name, @originalName, @extension, @compressed, @compressedSize, @fullSize, @byteArray); SELECT last_insert_rowid()";
                SQLiteCommand Command = new SQLiteCommand(commandText, DBConnection);
                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@originalName", originalName);
                Command.Parameters.AddWithValue("@extension", extension);
                Command.Parameters.AddWithValue("@byteArray", byteArray);
                Command.Parameters.AddWithValue("@extension", extension);
                Command.Parameters.AddWithValue("@byteArray", byteArray);
                Command.Parameters.AddWithValue("@compressed", compressed);
                Command.Parameters.AddWithValue("@compressedSize", compressedSize);
                Command.Parameters.AddWithValue("@fullSize", fullSize);
                var id = await Command.ExecuteScalarAsync();


                return new FileModel
                {
                    Id = Convert.ToInt32(id),
                    Name = name,
                    OriginalName = originalName,
                    Extension = extension
                };
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public async Task<FileModel> GetFile(int id)
        {
            try
            {
                var file = new FileModel();

                DBConnection.Open();
                SQLiteCommand Command = new SQLiteCommand
                {
                    Connection = DBConnection,
                    CommandText = $"SELECT * FROM files WHERE id={id}"
                };
                var sqlReader = await Command.ExecuteReaderAsync();

                await sqlReader.ReadAsync();

                file.Id = Convert.ToInt32(sqlReader["id"]);
                file.Name = sqlReader["name"].ToString();
                file.OriginalName = sqlReader["originalName"].ToString();
                file.Extension = sqlReader["extension"].ToString();
                file.Compressed = Convert.ToInt32(sqlReader["compressed"]) == 1 ? true : false;
                file.CompressedSize = Convert.ToInt64(sqlReader["compressedSize"]);
                file.FullSize = Convert.ToInt64(sqlReader["fullSize"]);
                file.ByteArray = (byte[])sqlReader["byteArray"];
                return file;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        private bool _ExistFilesTable()
        {
            try
            {
                DBConnection.Open();
                SQLiteCommand Command = new SQLiteCommand
                {
                    Connection = DBConnection,
                    CommandText = @"SELECT name FROM sqlite_master WHERE type='table' AND name='files';"
                };

                var sqlReader = Command.ExecuteScalar();
                if (Command.ExecuteScalar() == null)
                    return false;
                return true;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        private void _CreateFilesTable()
        {
            try
            {
                DBConnection.Open();
                using (SQLiteCommand command = new SQLiteCommand(DBConnection))
                {
                    command.CommandText =
                        @"CREATE TABLE [files] (
	                        [id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                            [name] char(100) NOT NULL,
                            [originalName] char(100) NOT NULL,
                            [extension] char(100) NOT NULL,
                            [compressed] INTEGER NOT NULL,
                            [fullSize] INTEGER NOT NULL,
                            [compressedSize] INTEGER NOT NULL,
                            [byteArray] blob
                         )";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public void Dispose()
        {
            DBConnection.Dispose();
        }
    }
}
