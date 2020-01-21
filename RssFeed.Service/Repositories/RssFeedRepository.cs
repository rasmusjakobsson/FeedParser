using System;
using RestSharp;
using RssFeed.Contracts;
using RssFeed.Models;

namespace RssFeed.Repositories
{
    public class RssFeedRepository: IRssFeedRepository
    {
        public RssFeedRepository()
        {
        }

        public RssFeedResponse CallRssFeed(string url)
        {
            var client = new RestClient();

            var request = new RestRequest(url, DataFormat.Json);

            var response = client.Get(request);

            Microsoft.Toolkit.Parsers.Rss.RssParser rssParser = new Microsoft.Toolkit.Parsers.Rss.RssParser();
            var parsedContent = rssParser.Parse(response.Content);
            

            return new RssFeedResponse { xmlReponse = response.Content };
        }
    }
}
