using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using UrlShortner.Core;

namespace UrlShortnerServiceApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class UrlShortnerController : ControllerBase
    {
        private readonly IUrlShortnerService _urlShortnerService;
        public UrlShortnerController(IUrlShortnerService urlShortnerService)
        {
            _urlShortnerService = urlShortnerService;
        }
        [Route("InsertUrl")]
        [HttpPost]
        public async Task<List<UrlDetails>> InsertUrl(UrlDetails url)
        { 
           return await _urlShortnerService.InsertUrl(url);
        }
        [Route("UpdateUrl")]
        [HttpPost]
        public async Task<List<UrlDetails>> UpdateUrl(UrlDetails url)
        {
            return await _urlShortnerService.UpdateUrl(url);
        }
        [Route("GetallUrl")]
        [HttpGet]
        public async Task<List<UrlDetails>> GetAllUrls()
        {
            return await _urlShortnerService.GetAllUrls();
        }
       
    }
}
