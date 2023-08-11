using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}