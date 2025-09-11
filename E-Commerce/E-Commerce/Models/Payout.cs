using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public enum PayoutStatus
    {
        Pending,    
        Accepted,
        Rejected
    }
    
    public class Payout
    { 
        public Guid PayoutId { get; set; }
        public decimal Amount { get; set; }
        public PayoutStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Seller")]
        public Guid? SellerId { get; set; }
        public virtual Seller? Seller { get; set; }
    }
}
