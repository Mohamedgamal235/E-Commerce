using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public enum RefundStatus
    {
        Pending,
        Accepted,
        Rejected,
    }
    public class Refund
    {
        public Guid RefundId { get; set; }
        [Required] public decimal Amount { get; set; }
        [Required] public RefundStatus Status { get; set; }
        [Required] public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("OrderItem")]
        public Guid OrderItemId { get; set; }
        public virtual OrderItem? OrderItem { get; set; } 

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User? User { get; set; } 
    }
}
