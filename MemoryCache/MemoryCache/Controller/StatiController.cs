using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemoryCache.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace MemoryCache.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatiController : ControllerBase
    {
        private IMemoryCache cache;
        public StatiController(IMemoryCache memoryCache)
        {
            this.cache = memoryCache;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(CallerHttp.GetStati());
        }
    }
}
