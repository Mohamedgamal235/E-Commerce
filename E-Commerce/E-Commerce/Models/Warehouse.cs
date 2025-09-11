using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Warehouse
    {
        public Guid WarehouseId { get; set; }
        [Required] public string Location { get; set; }
        [Required] public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<SkuWarehouse>? SkuWarehouses { get; set; } = new List<SkuWarehouse>();
    }
}
