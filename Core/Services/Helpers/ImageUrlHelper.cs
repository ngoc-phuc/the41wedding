using System;
using System.IO;

using Common.Configurations;
using Common.Dependency;
using Common.Extensions;
using Common.Helpers;

using Dtos.Shared;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Services.Helpers
{
    public static class ImageUrlHelper
    {
        private static readonly IUrlHelper UrlHelper = SingletonDependency<IUrlHelper>.Instance;

        private static readonly FileStorageConfig FileStorageConfig = SingletonDependency<IOptions<FileStorageConfig>>.Instance.Value;

        public static ImageUrlDto ToImageUrl(Guid? fileGuid, string extension)
        {
            var fileName = fileGuid.GetFileNameWithExtension(extension);

            return ToImageUrl(fileName);
        }

        public static ImageUrlDto ToImageUrl(Guid? fileGuid)
        {
            return ToImageUrl(fileGuid, ".png");
        }

        public static ImageUrlDto ToImageUrl(string fileName)
        {
            return fileName.IsNullOrWhiteSpace()
                ? null
                : new ImageUrlDto
                {
                    Guid = GetFileGuid(fileName).GetValueOrDefault(),
                    LargeSizeUrl = LargeSizeUrl(fileName),
                    ThumbSizeUrl = ThumbSizeUrl(fileName),
                };
        }

        public static string LargeSizeUrl(string fileName)
        {
            if (fileName.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }
            return UrlHelper.AbsoluteContent(string.Join("/", FileStorageConfig.ImageRelativeRequestPath, FileStorageConfig.LargeImageFolderName, fileName));
        }

        public static string ThumbSizeUrl(string fileName)
        {
            if (fileName.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }
            return UrlHelper.AbsoluteContent(string.Join("/", FileStorageConfig.ImageRelativeRequestPath, FileStorageConfig.ThumbImageFolderName, fileName));
        }

        public static string GetFileNameWithExtension(this Guid? fileGuild, string extension)
        {
            return fileGuild == null ? string.Empty : GetFileNameWithExtension(fileGuild.Value, extension);
        }

        public static string GetFileNameWithExtension(this Guid fileGuild, string extension)
        {
            return fileGuild + extension;
        }

        public static string NewImageFileName()
        {
            return GuidHelper.Create() + ".png";
        }

        public static Guid? GetFileGuid(string filename)
        {
            return GuidHelper.Parse(Path.GetFileNameWithoutExtension(filename));
        }

        public static string ToImageFileName(this Guid guid)
        {
            return guid + ".png";
        }
    }
}