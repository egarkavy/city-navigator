using CityNavigator.Model.Attributes;
using CityNavigator.Services.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Services.Models.Category
{
    [Collection("units")]
    public class Category : ICollection
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonExtraElements]
        public BsonDocument Other { get; set; }
    }
}
