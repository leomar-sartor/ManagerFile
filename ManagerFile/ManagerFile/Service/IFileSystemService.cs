using ManagerFile.Fomatter;
using ManagerFile.Models;
using System.Collections.Generic;

namespace ManagerFile.Service
{
    public interface IFileSystemService
    {
        IEnumerable<FileSystemObject> GetAllFileSystemObject(string fullName);

        object ToJson(
            IEnumerable<FileSystemObject> objs,
            IFileSystemFormatter fileSystemFormatter = null
            );

        bool DirectoryExists(string fullName);
    }
}
