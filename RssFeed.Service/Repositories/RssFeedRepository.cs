using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
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

        public List<RssFeedResponse> CallRssFeed(string url)
        {
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);
            return feed.Items.Select(item =>
                MapRssFeedResponse(item)).ToList();
        }

        private RssFeedResponse MapRssFeedResponse(SyndicationItem item)
        {
            try
            {
                return new RssFeedResponse
                {
                    CheckSum = item.Links.FirstOrDefault(link => link.MediaType == "audio/mpeg").Length,
                    Title = item.Title.Text,
                    Url = item.Links.FirstOrDefault(link => link.MediaType == "audio/mpeg").Uri.AbsoluteUri
                };
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }
}
