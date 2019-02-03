using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;


namespace CityNavigator.Services.Models.SubCategory
{
    public class SubCategoryViewModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public ObjectId CategoryId { get; set; }
    }
}
