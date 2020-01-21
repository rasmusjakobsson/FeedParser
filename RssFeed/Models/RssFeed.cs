using System;
using System.Collections.Generic;

namespace RssFeed.Api.Models
{
    public class Episodes
    {
        public List<EpisodeInfo> EpisodeInfo { get; set; }
    }

    public class EpisodeInfo
    {
        public string Title { get; set; }
        public long CheckSum { get; set; }
        public string Url { get; set; }
    }
}
