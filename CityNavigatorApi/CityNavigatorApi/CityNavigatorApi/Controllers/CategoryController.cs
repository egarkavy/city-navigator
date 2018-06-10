using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityNavigator.Models;
using CityNavigator.Services.Base;
using CityNavigator.Services.Models.Category;
using CityNavigator.Services.Models.SubCategory;
using CityNavigatorApi.Base;
using Microsoft.AspNetCore.Mvc;

namespace CityNavigatorApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly IMongoRepository repository;

        public CategoryController(IMongoRepository repository)
        {
            this.repository = repository;
        }
        // GET api/values
        [HttpGet]
        public List<CategoryViewModel> Get()
        {
            var categories =

                (from category in repository.Query<Category>()
                 join sub in repository.Query<SubCategory>() on category.Id equals sub.CategoryId
                 into subC
                 select new { category, subC }).ToList();


            var result = Mapper.Map<List<CategoryViewModel>>(categories);
            return result;
        }
    }
}