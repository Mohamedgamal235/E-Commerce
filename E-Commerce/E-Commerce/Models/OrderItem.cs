using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }
        [Required] public int Quantity { get; set; }
        [Required] public decimal Price { get; set; }
        public DateTime? ReturnableUntil { get; set; }
        public DateTime OrderedAt { get; set; }

        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        public virtual Order? Order { get; set; }

        [ForeignKey("Sku")]
        public Guid? SkuId { get; set; }
        public virtual SKU? Sku { get; set; }
        public virtual ICollection<Refund>? Refunds { get; set; } = new List<Refund>();
    }
}
