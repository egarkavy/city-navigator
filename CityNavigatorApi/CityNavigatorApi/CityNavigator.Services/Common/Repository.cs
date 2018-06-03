using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CityNavigator.Services.Common
{
    public class Repository : IRepository
    {
        MongoClient _client;
        IMongoDatabase _db;

        public Repository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("Places");
        }

        public IMongoQueryable<TEntity> GetList<TEntity>()
        {
            return _db.GetCollection<TEntity>("").AsQueryable().Where(x => true);
        }
    }
}
