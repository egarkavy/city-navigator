using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityNavigatorApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace CityNavigatorApi.Controllers
{
    [Route("api/[controller]")]
    public class PlacesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}