using ManagerFile.Fomatter;
using ManagerFile.Models;
using ManagerFile.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ManagerFile.Service
{
    public sealed class DefaultFileSystemService : IFileSystemService
    {
        private readonly IFileSystemRepository _fileSystemRepository;

        public DefaultFileSystemService(IFileSystemRepository filesSystemRepository)
        {
            _fileSystemRepository = filesSystemRepository;
        }

        public IEnumerable<FileSystemObject> GetAllFilesSystemObject(string fullName)
        {
            var objs = _fileSystemRepository.SelectMany(fullName).ToList();

            if (objs.Any())
                objs.OrderBy(obj => obj.IsFile.ToString());

            return objs;
        }
        public object ToJson(IEnumerable<FileSystemObject> objs, IFileSystemFormatter fileSystemFormatter = null)
        {
            fileSystemFormatter = fileSystemFormatter ?? FormatterFactory.CreateInstance();

            return fileSystemFormatter.ToJson(objs);
        }

        public bool DirectoryExists(string fullName)
        {
            var result = _fileSystemRepository.Exists(fullName);

            return result;
        }

        public IEnumerable<FileSystemObject> GetAllFileSystemObject(string fullName)
        {
            var objs = _fileSystemRepository.SelectMany(fullName).ToList();

            if (objs.Any())
                objs.OrderBy(obj => obj.IsFile.ToString());

            return objs;
        }


    }
}
