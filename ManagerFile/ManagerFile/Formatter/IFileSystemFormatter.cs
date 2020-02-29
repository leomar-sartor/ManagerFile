using ManagerFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerFile.Fomatter
{
    public interface IFileSystemFormatter
    {
        object ToJson(IEnumerable<FileSystemObject> fileSystemObjects);
    }
}
