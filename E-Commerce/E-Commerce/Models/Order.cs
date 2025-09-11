using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{

    public enum Status
    {
        Pending,          
        Delivering, 
        Shipped,    
        Delivered,     
        Cafunded 
      
    }
    public class Order
    {
        public Guid OrderId { get; set; }
        [Required] public int OrderNumber { get; set; }
        [Required] public Status Status { get; set; }
        [Required] public int TotalWeight { get; set; }
        [Required] public int TotalPrice { get; set; }
        [Required] public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Shipment")]
        public Guid? ShipmentId { get; set; }
        public virtual Shipment? Shipment { get; set; }

        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        public virtual ICollection<Payment>? Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Refund>? Refunds { get; set; } = new List<Refund>();
    }
}
