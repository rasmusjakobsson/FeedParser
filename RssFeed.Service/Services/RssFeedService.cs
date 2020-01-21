using System;
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

        public Models.RssFeed GetRssFeed(string url)
        {
            var rssFeedResponse = _rssFeedRepository.CallRssFeed(url);
            var serializer = new XmlSerializer(typeof(Models.RssFeed));

            using(var reader = new StringReader(rssFeedResponse.xmlReponse))
            {
                return serializer.Deserialize(reader) as Models.RssFeed;
            }

        }
    }
}
