using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern3Strategy.Good
{
    internal class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MOV");
        }

        public string Extension()
        {
            return "MOV";
        }
    }
}
