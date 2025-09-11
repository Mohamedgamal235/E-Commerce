using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public enum PromotionType
    {
        PercentageDiscount,  
        FixedAmountDiscount,
        Coupon, 
        _2rby_ya_madam_3orodna_tamam,
        Seebak_Men_Elwekala_We_3ndna_T3ala,        
        FreeShipping,   
    }

    public class Promotion
    {
        public Guid PromotionId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public PromotionType Type { get; set; }
        public int? DiscountPercentage { get; set; }
        public string? CouponCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
        
    }
}
