using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern16Flyweight
{
    internal class Crop
    {
        private int _x;
        private int _y;
        private CropIcon _cropIcon;

        public Crop(int x, int y, CropIcon cropIcon)
        {
            _x = x;
            _y = y;
            _cropIcon = cropIcon;
        }

        public void Render()
        {
            Console.WriteLine($"Drawing {_cropIcon.GetCropType()} at ({_x}, {_y}).");
        }
    }
}
