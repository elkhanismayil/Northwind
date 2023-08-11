using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstarct
{
    public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GetAllByCategoryId(int id);
        List<Products> GetBynitPrice(decimal min, decimal max);
    }
}