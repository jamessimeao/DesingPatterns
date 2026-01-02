namespace Pattern16Flyweight
{
    internal class Program()
    {
        public static void Main()
        {
            CropIconFactory cropIconFactory = new CropIconFactory();
            CropService cropService = new CropService(cropIconFactory);
            List<Crop> crops = cropService.GetCrops();
            foreach(Crop crop in crops)
            {
                crop.Render();
            }
        }
    }
}