using Microsoft.AspNetCore.Http;

namespace Dtos.Shared.Inputs
{
    public class FileUploadDto
    {
        public IFormFile File { get; set; }
    }
}