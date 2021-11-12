using PaymentWebsite.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentWebsite.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
    }
}
