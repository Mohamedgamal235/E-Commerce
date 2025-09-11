using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class SKU
    {
        public Guid SkuId { get; set; }
        public decimal Weight { get; set; }
        public string SkuImageUrl { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<SkuWarehouse>? SkuWarehouses { get; set; } = new List<SkuWarehouse>();
        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        
    }
}
