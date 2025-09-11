using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        [Required] public string Name { get; set; } 
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
