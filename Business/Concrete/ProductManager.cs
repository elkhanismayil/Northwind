using Business.Abstarct;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Products> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Products> GetBynitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}