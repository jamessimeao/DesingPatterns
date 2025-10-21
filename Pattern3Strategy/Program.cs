using Pattern3Strategy.Good;

namespace Pattern3Strategy
{
    internal class Program
    {
        public static void Main()
        {
            VideoStorage videoStorage = new VideoStorage(
                new CompressorMOV(),
                new OverlayBlackAndWhite());
            videoStorage.Store("/videos/some-movie");

            videoStorage.SetCompressor(new CompressorMP4());
            videoStorage.SetOverlay(new OverlayNone());
            videoStorage.Store("/videos/some-movie");
        }
    }
}