using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Seller : User
    {
        [Required] public decimal AvailableBalance { get; set; }
        [Required] public decimal PendingBalance { get; set; }
        
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
        public virtual ICollection<Payout>? Payouts { get; set; } = new List<Payout>();
    }
}
