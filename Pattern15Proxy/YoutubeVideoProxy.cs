using Pattern15Proxy.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern15Proxy
{
    internal class YoutubeVideoProxy : Video
    {
        private string _videoId;
        private YoutubeVideo? _youtubeVideo;
        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if(_youtubeVideo == null)
            {
                _youtubeVideo = new YoutubeVideo(_videoId);
            }
            _youtubeVideo.Render();
        }
    }
}
