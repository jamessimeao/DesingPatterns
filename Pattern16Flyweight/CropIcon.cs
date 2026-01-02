using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern16Flyweight
{
    internal class CropIcon
    {
        private readonly CropType _cropType;
        private readonly byte[]? _icon;

        public CropIcon(CropType cropType, byte[]? icon)
        {
            _cropType = cropType;
            _icon = icon;
        }

        public CropType GetCropType()
        {
            return _cropType;
        }
    }
}
