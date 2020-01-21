using RssFeed.Models;

namespace RssFeed.Contracts
{
    public interface IRssFeedRepository
    {
        RssFeedResponse CallRssFeed(string url);
    }
}
