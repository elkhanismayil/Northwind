using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Products> products;
        public InMemoryProductDal()
        {
            this.products = new List<Products>
            {
                new Products { ProductID=1, CategoryID=1,ProductName="Bardak",UnitPrice=15, UnitsInStock=15 },
                new Products { ProductID=2, CategoryID=1,ProductName="Kamera",UnitPrice=2000, UnitsInStock=5 },
                new Products { ProductID=3, CategoryID=2,ProductName="Telefon",UnitPrice=3000, UnitsInStock=3 },
                new Products { ProductID=4, CategoryID=2,ProductName="Klavye",UnitPrice=1000, UnitsInStock=20 },
                new Products { ProductID=5, CategoryID=2,ProductName="Fare",UnitPrice=80, UnitsInStock=120 }
            };
        }

        public void Add(Products product)
        {
            products.Add(product);
        }

        public void Delete(Products product)
        {
            Products productToDelete = products.SingleOrDefault(p => p.ProductID == product.ProductID);
            products.Remove(productToDelete);

        }

        public List<Products> GetAll()
        {
            return products;
        }

        public List<Products> GetAllByCategory(int categoryId)
        {
            return products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public void Update(Products product)
        {
            Products productToUpdate = products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Products Get(Expression<Func<Products, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}