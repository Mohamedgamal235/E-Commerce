using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public enum ProductStatus
    {
        Visible,       
        Hidden,     
        Banned,     
        OutOfStock,       
        Pending 
    }
    
    public class Product
    {
        public Guid ProductId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public decimal Price { get; set; }
        [Required] public string ImageUrl { get; set; }
        [Required] public string Description { get; set; }
        [Required] public ProductStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("Seller")]
        public Guid SellerId { get; set; }
        public virtual Seller? Seller { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<ProductTags>? ProductTags { get; set; } = new List<ProductTags>();
        public virtual ICollection<Promotion>? Promotions { get; set; } = new List<Promotion>();
        public virtual ICollection<SKU>? SKUs { get; set; } = new List<SKU>();
        public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
    }
}
