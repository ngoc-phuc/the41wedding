using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Processing.Transforms;

namespace Utility
{
    public static class ImageResizeHelper
    {
        public static void ResizeToThumbSize(string imagePath)
        {
            using (var image = Image.Load(imagePath))
            {
                image.Mutate(
                    x => x.Resize(200, 200 * image.Height / image.Width));
                image.Save(imagePath);
            }
        }
    }
}