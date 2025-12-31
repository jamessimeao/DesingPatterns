namespace Pattern13Adapter
{
    internal class Program()
    {
        public static void Main()
        {
            Video video = new Video();
            VideoEditor videoEditor = new VideoEditor(video);

            RainbowColor rainbowColor = new RainbowColor();
            videoEditor.ApplyColor(rainbowColor);

            RainbowAdapter rainbowAdapter = new RainbowAdapter();
            videoEditor.ApplyColor(rainbowAdapter);
        }
    }
}