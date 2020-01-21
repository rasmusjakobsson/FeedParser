using System;
namespace RssFeed.Contracts
{
    public interface IRssFeedService
    {
        Models.RssFeed GetRssFeed(string url);
    }
}
