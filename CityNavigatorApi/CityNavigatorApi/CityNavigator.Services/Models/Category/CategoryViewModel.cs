using CityNavigator.Services.Models.SubCategory;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Services.Models.Category
{
    public class CategoryViewModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<SubCategoryViewModel> Subcategories { get; set; }
    }
}
