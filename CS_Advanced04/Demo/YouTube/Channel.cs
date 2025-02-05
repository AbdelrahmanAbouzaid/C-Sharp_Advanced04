using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.YouTube
{
    internal class Channel
    {
        public string Title { get; set; }
        public List<Video> Videos { get; set; } = new List<Video>();
        public List<Subscriper> Subscribers { get; set; } = new List<Subscriper>();
        public void AddVideo(Video video)
        {
            Videos.Add(video);
            if (Uploaded is not null)
                Uploaded.Invoke(this, video);
        }
        public event Action<Channel, Video> Uploaded;
    }
}
