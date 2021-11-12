using System;
using System.ComponentModel.DataAnnotations;

namespace PaymentWebsite.Entity.Concrete
{
    /// <summary>
    /// This is Product Entity
    /// </summary>
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public DateTime ProductCreateDate { get; set; }
        public string ProductImage { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
