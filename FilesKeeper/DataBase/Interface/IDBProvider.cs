using FilesKeeper.DataBase.Models;
using System;
using System.Threading.Tasks;

namespace FilesKeeper.DataBase.Interface
{
    public interface IDBProvider : IDisposable
    {
        Task<FileModel[]> GetListFiles();
        Task<FileModel> SaveFile(string name, string originalName, string extension, bool compressed, long compressedSize, long fullSize, byte[] byteArray);
        Task<FileModel> GetFile(int id);
    }
}
