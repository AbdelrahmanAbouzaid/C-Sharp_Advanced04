using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.YouTube
{
    internal class Subscriper
    {
        public string Name { get; set; }
        public void Notify(Channel channel, Video video)
        {
            Console.WriteLine($"Channel {channel} Uploaded Video {video}, {Name}");
        }
        public override string ToString()
        {
            return $"Subscriper Name: {Name}";
        }
    }
}
