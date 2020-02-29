using ManagerFile.Fomatter;
using ManagerFile.Service;
using Microsoft.AspNetCore.Mvc;

namespace ManagerFile.Controllers
{
    public sealed class FileSystemController : Controller
    {
        private readonly IFileSystemService _fileSystemService;

        public FileSystemController(IFileSystemService fileSystemService)
        {
            _fileSystemService = fileSystemService;
        }

        //http://localhost:60341/FileSystem?formatterName=Default
        //http://localhost:60341/FileSystem?formatterName=Humanizer
        public IActionResult Index(string fullName = null, string formatterName = null)
        {
            var data = _fileSystemService.GetAllFileSystemObject(fullName);

            var json = _fileSystemService.ToJson(data, FormatterFactory.CreateInstance(formatterName));

            return Json( json);
        }

        [ActionName("check-directory")]
        public IActionResult DirectoryExists(string fullName = null)
        {
            var exists = _fileSystemService.DirectoryExists(
                fullName);

            return Json(exists);
        }
    }
}
