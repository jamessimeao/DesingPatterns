using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern16Flyweight
{
    internal class CropService
    {
        private readonly CropIconFactory _cropIconFactory;

        public CropService(CropIconFactory iconFactory)
        {
            _cropIconFactory = iconFactory;
        }

        public List<Crop> GetCrops()
        {
            List<Crop> cropsList = new List<Crop>();

            // fetch from db
            CropIcon cropIcon = _cropIconFactory.GetCropIcon(CropType.Carrot);
            for(int i = 0; i < 3; i++)
            {
                cropsList.Add(new Crop(1, 4 + i, cropIcon));
            }

            return cropsList;
        }
    }
}
