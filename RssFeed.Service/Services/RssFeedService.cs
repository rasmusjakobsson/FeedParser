using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using RssFeed.Contracts;

namespace RssFeed.Services
{
    public class RssFeedService: IRssFeedService
    {
        private readonly IRssFeedRepository _rssFeedRepository;

        public RssFeedService(IRssFeedRepository rssFeedRepository)
        {
            _rssFeedRepository = rssFeedRepository;
        }

        public List<Models.RssFeedResponse> GetRssFeed(string url)
        {
            return _rssFeedRepository.CallRssFeed(url);
        }
    }
}
