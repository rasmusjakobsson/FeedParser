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
        public RssFeed.Api.Models.RssFeed Get(string url)
        {
            var parsedFeed = _rssFeedService.GetRssFeed(url);
            return null;
        }
    }
}
