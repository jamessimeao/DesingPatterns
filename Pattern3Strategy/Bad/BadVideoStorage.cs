using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Bad
{
    internal class BadVideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public BadVideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string fileName)
        {
            switch (_compressor)
            {
                case (Compressors.MOV):
                    Console.WriteLine("Compressing using MOV");
                    break;
                case (Compressors.MP4):
                    Console.WriteLine("Compressing using MP4");
                    break;
                case (Compressors.WEBM):
                    Console.WriteLine("Compressing using WEBM");
                    break;
            }

            switch (_overlay)
            {
                case (Overlays.None):
                    Console.WriteLine("Not applying overlay");
                    break;
                case (Overlays.BlackAndWhite):
                    Console.WriteLine("Applying black and white overlay");
                    break;
                case (Overlays.Blur):
                    Console.WriteLine("Applying blur overlay");
                    break;
            }

            Console.WriteLine($"Storing video to {fileName}.{_compressor}");
        }
    }
}
