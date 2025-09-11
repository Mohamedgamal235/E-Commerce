using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class ProductTags
    {
        public Guid ProductTagsId { get; set; }
        public string Tag { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
