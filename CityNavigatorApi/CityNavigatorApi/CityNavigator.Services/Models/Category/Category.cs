using CityNavigator.Model.Attributes;
using CityNavigator.Services.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using CityNavigator.Services.Models.SubCategory;

namespace CityNavigator.Services.Models.Category
{
    [Collection("categories")]
    public class Category : ICollection
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        public IEnumerable<SubCategory.SubCategory> Subcategories { get; set; }

        [BsonExtraElements]
        public BsonDocument Other { get; set; }
    }
}
