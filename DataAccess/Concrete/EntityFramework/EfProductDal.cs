using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Products product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Products product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(product);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public void Update(Products product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> predicate = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return predicate == null 
                ? context.Set<Products>().ToList() 
                : context.Set<Products>().Where(predicate).ToList();
            }
        }

        public Products Get(Expression<Func<Products, bool>> predicate)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Products>().SingleOrDefault(predicate);
            }
        }
    }
}