using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MP4");
        }
        public string Extension()
        {
            return "MP4";
        }
    }
}
