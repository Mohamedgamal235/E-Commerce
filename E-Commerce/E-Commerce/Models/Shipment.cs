using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public enum ShipmentStatus
    {
        Pending,    
        Delivering,  
        Delivered,
        Failed,      
    }

    public class Shipment
    {
        public Guid ShipmentId { get; set; }
        [Required] public string TrackingNumber { get; set; }
        [Required] public ShipmentStatus Status { get; set; }
        [Required] public decimal ShippingCost { get; set; }
        public DateTime? ShippedAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
    }
}
