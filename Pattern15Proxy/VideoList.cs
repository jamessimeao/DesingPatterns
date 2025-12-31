using Pattern15Proxy.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern15Proxy
{
    internal class VideoList
    {
        private Dictionary<string, Video> _videoList = new Dictionary<string, Video>();

        public void Add(Video video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoId)
        {
            Video video = _videoList[videoId];
            video.Render();
        }
    }
}
