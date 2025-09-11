using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class UserAddress
    {
        public Guid UserAddressId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        
    }
}
