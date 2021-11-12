using System.ComponentModel.DataAnnotations;

namespace PaymentWebsite.Entity.Concrete
{
    /// <summary>
    /// This is User Entity
    /// </summary>
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserAbout { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
