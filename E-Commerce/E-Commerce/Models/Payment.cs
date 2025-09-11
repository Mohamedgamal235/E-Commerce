using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public enum PaymentStatus
    {
        Pending,    
        Completed,   
        Failed,      
        Refunded,    
        Cancelled  
    }

    public class Payment
    {
        public Guid PaymentId { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public virtual User? User { get; set; } 


        [ForeignKey("Order")]
        public Guid? OrderId { get; set; }
        public virtual Order? Order { get; set; }
        
    }
}
