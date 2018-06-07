using CityNavigator.Model.Attributes;
using CityNavigator.Services.Base;
using CityNavigator.Services.Models.Comment;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Models
{
    [Collection("units")]
    public class Place: ICollection
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("subCategoryId")]
        public ObjectId CategoryId { get; set; }
        [BsonElement("location")]
        public Location Location { get; set; }
        [BsonElement("headerTitle")]
        public string Tittle { get; set; }
        [BsonElement("shortDescription")]
        public string ShortDescription { get; set; }
        [BsonElement("metaDescription")]
        public string MetaDescription { get; set; }
        public string AdvDescription { get; set; }
        [BsonElement("mainContent")]
        public string HtmlContent { get; set; }
        [BsonElement("workingHours")]
        public List<string> WorkingHours { get; set; }
        [BsonElement("addresses")]
        public List<string> Addresses { get; set; }
        [BsonElement("phoneNumbers")]
        public List<string> PhoneNumbers { get; set; }

        public List<Comment> Comments { get; set; }

        [BsonExtraElements]
        public BsonDocument Other { get; set; }
    }


    public class Location
    {
        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }
        [BsonExtraElements]
        public BsonDocument Other { get; set; }
    }
}
