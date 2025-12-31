using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern13Adapter
{
    internal class VideoEditor
    {
        private Video _video;

        public VideoEditor(Video video)
        {
            _video = video;
        }

        public void ApplyColor(Color color)
        {
            color.Apply(_video);
        }
    }
}
