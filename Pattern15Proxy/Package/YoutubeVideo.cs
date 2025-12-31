using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern15Proxy.Package
{
    internal class YoutubeVideo : Video
    {
        private string _videoId;

        public YoutubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering video {_videoId}.");
        }

        private void Download()
        {
            Console.WriteLine($"Downloading video with id {_videoId} from Youtube API.");
        }
    }
}
