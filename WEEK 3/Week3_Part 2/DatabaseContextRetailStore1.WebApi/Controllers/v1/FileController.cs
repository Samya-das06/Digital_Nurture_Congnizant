using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Asp.Versioning;
using DatabaseContextRetailStore1.Application.Interfaces;
using DatabaseContextRetailStore1.Application.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseContextRetailStore1.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class FileController(IFileManagerService fileManagerService) : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetFile(string name)
        {
            var bytes = await fileManagerService.Download(name);

            return File(bytes, MediaTypeNames.Application.Octet, name);
        }

        [HttpPost]
        public async Task<BaseResult<string>> UploadFile(string name, IFormFile file)
        {
            using var memoryStream = new MemoryStream();

            await file.CopyToAsync(memoryStream);
            await fileManagerService.Create(name, memoryStream.ToArray());
            await fileManagerService.SaveChangesAsync();

            return name;
        }
    }
}
