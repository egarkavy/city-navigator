using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityNavigator.Models;
using CityNavigator.Services.Base;
using CityNavigatorApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace CityNavigatorApi.Controllers
{
    [Route("api/[controller]")]
    public class PlacesController : Controller
    {
        private readonly IMongoRepository repository;

        public PlacesController(IMongoRepository repository)
        {
            this.repository = repository;
        }
        // GET api/values
        [HttpGet]
        public List<PlaceViewModel> Get()
        {
            var databaseList = repository.Query<Place>().ToList();
            var result = Mapper.Map<List<PlaceViewModel>>(databaseList);
            return result;
        }
    }
}