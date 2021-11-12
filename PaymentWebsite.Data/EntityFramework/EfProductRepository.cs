using PaymentWebsite.Data.Abstract;
using PaymentWebsite.Data.Repositories;
using PaymentWebsite.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentWebsite.Data.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
    }
}
