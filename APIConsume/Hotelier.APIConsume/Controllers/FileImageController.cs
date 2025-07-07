using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Hotelier.APIConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile formFile)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "files/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await formFile.CopyToAsync(stream);
            return Created("", formFile);
        }

    }
}
