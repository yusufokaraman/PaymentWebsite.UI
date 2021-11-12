using PaymentWebsite.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentWebsite.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetProductById(int id);
        List<Product> GetProductsListCategory();
    }
}
