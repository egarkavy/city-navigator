using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityNavigator.Models;
using CityNavigator.Services.Base;
using CityNavigator.Services.Models.Comment;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace CityNavigatorApi.Controllers
{
    public class CommentController : Controller
    {
        private readonly IMongoRepository repository;

        public CommentController(IMongoRepository repository)
        {
            this.repository = repository;
        }

        [HttpPut]
        public async void Put(ObjectId placeId, Comment comment)
        {
            var place = await repository.Get<Place>(placeId);
            place.Comments.Add(comment);
            await repository.Update(placeId, place);

            return;
        }
    }
}