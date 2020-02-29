using ManagerFile.Fomatter;
using ManagerFile.Service;
using Microsoft.AspNetCore.Mvc;

namespace ManagerFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class FileSystemAPIController : ControllerBase
    {
        private readonly IFileSystemService _fileSystemService;

        public FileSystemAPIController(IFileSystemService fileSystemService)
        {
            _fileSystemService = fileSystemService;
        }

        //http://localhost:56078/api/FileSystem?formatterName=Default
        //http://localhost:56078/api/FileSystem?formatterName=Humanizer
        // GET api/FileSystem
        [HttpGet]
        public ActionResult Get(string fullName = null, string formatterName = null)
        {
            var data = _fileSystemService.GetAllFileSystemObject(fullName);

            var json = _fileSystemService.ToJson(data, FormatterFactory.CreateInstance(formatterName));

            return Ok(json);
        }

        //http://localhost:56078/api/FileSystem/DirectoryExists/leomar
        [HttpGet("DirectoryExists/{fullName}")]
        public ActionResult DirectoryExists(string fullName = null)
        {
            var exists = _fileSystemService.DirectoryExists(
                fullName);

            return Ok(exists);
        }
    }
}
