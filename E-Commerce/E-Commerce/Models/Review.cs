using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public short Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User? User { get; set; }


        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        
    }
}
