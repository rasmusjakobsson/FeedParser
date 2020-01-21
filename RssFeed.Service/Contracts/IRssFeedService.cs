using System;
using System.Collections.Generic;

namespace RssFeed.Contracts
{
    public interface IRssFeedService
    {
        List<Models.RssFeedResponse> GetRssFeed(string url);
    }
}
