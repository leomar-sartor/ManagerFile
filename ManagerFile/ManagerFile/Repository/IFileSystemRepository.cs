using ManagerFile.Models;

namespace ManagerFile.Repository
{
    public interface IFileSystemRepository : ISelectRepository<FileSystemObject>, IDeleteRepository<FileSystemObject>
    {
        bool Exists(string fullName);
    }
}
