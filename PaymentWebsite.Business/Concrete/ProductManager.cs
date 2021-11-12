using PaymentWebsite.Business.Abstract;
using PaymentWebsite.Data.Abstract;
using PaymentWebsite.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace PaymentWebsite.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductById(int id)
        {
            return _productDal.GetAll(x => x.ProductId == id);
        }

        public List<Product> GetProductsListCategory()
        {
            return _productDal.GetListCategory();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
