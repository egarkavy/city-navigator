using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityNavigator.Services.Common
{
    public interface IRepository
    {
        IMongoQueryable<TEntity> GetList<TEntity>();
    }
}
