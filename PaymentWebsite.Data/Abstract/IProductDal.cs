﻿using PaymentWebsite.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentWebsite.Data.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> GetListCategory();
    }
}
