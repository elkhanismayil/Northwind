using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstarct
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}