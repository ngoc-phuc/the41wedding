using System.IO;

namespace Common.Configurations
{
    public class FileStorageConfig
    {
        public string Host { get; set; }

        public string LargeImageFolderName => "large";

        public string ThumbImageFolderName => "thumb";

        public string ImageRelativePhysicalPath { get; set; }

        public string ImageAbsolutePhysicalPath { get; set; }

        public string TemplateAbsolutePhysicalPath { get; set; }

        public string BidTransferDocTemplateAbsolutePhysicalPath { get; set; }

        public string BidReviewDocumentTemplateAbsolutePhysicalPath { get; set; }

        public string BidPlanningAssignmentDocTemplateAbsolutePhysicalPath { get; set; }

        public string DocumentAbsolutePhysicalPath { get; set; }

        public string LargeImageAbsolutePhysicalPath => Path.Combine(ImageAbsolutePhysicalPath, LargeImageFolderName);

        public string ThumbImageAbsolutePhysicalPath => Path.Combine(ImageAbsolutePhysicalPath, ThumbImageFolderName);

        public string ImageRelativeRequestPath { get; set; }
    }
};