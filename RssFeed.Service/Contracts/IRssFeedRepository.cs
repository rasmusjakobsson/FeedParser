using RssFeed.Models;
using System.Collections.Generic;

namespace RssFeed.Contracts
{
    public interface IRssFeedRepository
    {
        List<RssFeedResponse> CallRssFeed(string url);
    }
}
