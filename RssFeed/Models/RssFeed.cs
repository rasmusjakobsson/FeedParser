using System;
namespace RssFeed.Api.Models
{
    public class RssFeed
    {
        public RssFeed()
        {
        }

        public string Title { get; set; }
        public int CheckSum { get; set; }
        public string Url { get; set; }
    }
}
