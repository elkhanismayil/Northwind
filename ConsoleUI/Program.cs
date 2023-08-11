using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {


            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var Product in productManager.GetBynitPrice(10,100))
            {
                Console.WriteLine(Product.ProductName);
            }
        }
    }
}