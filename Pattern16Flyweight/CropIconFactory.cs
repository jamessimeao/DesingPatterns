using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern16Flyweight
{
    internal class CropIconFactory
    {
        // cache
        private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();

        public CropIcon GetCropIcon(CropType cropType)
        {
            if(!_icons.ContainsKey(cropType))
            {
                _icons[cropType] = new CropIcon(cropType, null);
            }
            return _icons[cropType];
        }
    }
}
