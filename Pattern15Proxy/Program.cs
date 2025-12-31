using Pattern15Proxy.Package;

namespace Pattern15Proxy
{
    internal class Program()
    {
        public static void Main()
        {
            VideoList videoList = new VideoList();
            String[] videoIds = { "1234", "abcde", "vulkan123" };

            foreach(String videoId in videoIds)
            {
                videoList.Add(new YoutubeVideoProxy(videoId));
            }

            videoList.Watch("abcde");
        }
    }
}