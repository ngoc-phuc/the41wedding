using System;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Utility.BarcodeReader
{
    public static class BarcodeReaderHelper
    {
        public static string ScanBarcode(byte[] data)
        {
            try
            {
                using (var image = Image.Load(data))
                {
                    var reader = new BarcodeReader<Rgba32>();
                    var result = reader.Decode(image);

                    return result?.Text;
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}