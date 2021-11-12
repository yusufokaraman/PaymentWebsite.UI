using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaymentWebsite.Entity.Concrete
{
    /// <summary>
    /// This is Category Entity
    /// </summary>
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<Product> Products { get; set; }
    }
}
