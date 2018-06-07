using CityNavigator.Services.Models.Comment;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Models
{
    public class PlaceViewModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public ObjectId CategoryId { get; set; }
        public LocationViewModel Location { get; set; }
        public string Tittle { get; set; }
        public string ShortDescription { get; set; }
        public string MetaDescription { get; set; }
        public string AdvDescription { get; set; }
        public string HtmlContent { get; set; }
        public List<string> WorkingHours { get; set; }
        public List<string> Addresses { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public List<Comment> Comments { get; set; }
    }

    public class LocationViewModel
    {
        public List<double> Coordinates { get; set; }
    }
}

