using System;

namespace Dtos.Shared
{
    public class ImageUrlDto
    {
        public Guid Guid { get; set; }

        public string ThumbSizeUrl { get; set; }

        public string LargeSizeUrl { get; set; }
    }
}