using System;
using System.Linq;
using com.miaow.Core.Domain.Entities;
using com.miaow.Core.Domain.Repositories;

namespace com.miaow.DataServices
{
    public class NorthwindRepository<TPrimaryKey, TEntity> : Repository<TPrimaryKey, TEntity>
        where TEntity : IEntity<TPrimaryKey>
    {
        public override IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
