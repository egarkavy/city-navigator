using AutoMapper;
using CityNavigator.Models;
using CityNavigator.Services.Models.Category;
using CityNavigator.Services.Models.SubCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Services.Mappings
{
    public class PlaceMappings : Profile
    {
        public PlaceMappings()
        {
            CreateMap<Place, PlaceViewModel>();
            CreateMap<PlaceViewModel, Place>();

            CreateMap<Location, LocationViewModel>();
            CreateMap<LocationViewModel, Location>();

            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();

            CreateMap<Category, SubCategoryViewModel>();
            CreateMap<SubCategoryViewModel, Category>();
        }
       
    }
}
