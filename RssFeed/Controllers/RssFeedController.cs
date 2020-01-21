using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RssFeed.Api.Models;
using RssFeed.Contracts;

namespace RssFeed.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class RssFeedController : ControllerBase
    {
        private readonly IRssFeedService _rssFeedService;

        public RssFeedController(IRssFeedService rssFeedService)
        {
            _rssFeedService = rssFeedService;
        }
        [HttpGet]
        public List<EpisodeInfo> Get(string url)
        {
            return MapRssFeed(_rssFeedService.GetRssFeed(url));            
        }

        private List<EpisodeInfo> MapRssFeed(List<RssFeed.Models.RssFeedResponse> rssFeeds)
        {
            return rssFeeds.Select(rssFeed => new EpisodeInfo { CheckSum = rssFeed.CheckSum, Title = rssFeed.Title, Url = rssFeed.Url }).ToList();
        }
    }
}
