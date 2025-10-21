using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class CompressorWEBM : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using WEBM");
        }

        public string Extension()
        {
            return "WEBM";
        }
    }
}
