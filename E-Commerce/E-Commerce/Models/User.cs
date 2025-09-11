
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public virtual ICollection<UserAddress>? Addresses { get; set; } = new List<UserAddress>();
        public virtual ICollection<Payment>? Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Refund>? Refunds { get; set; } = new List<Refund>();
        public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
    }
}
