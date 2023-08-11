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


            ProductManager categoryManager = new ProductManager(new EfProductDal());
            int number = 1;

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(number + ". " + category.ProductName);
                number++;
            }
        }
    }
}