using AutoMapper;
using CityNavigator.Models;
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
        }
       
    }
}
