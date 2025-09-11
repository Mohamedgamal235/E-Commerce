using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class SkuWarehouse
    {
        [ForeignKey("Sku")]
        public Guid SkuId { get; set; }
        public virtual SKU? Sku { get; set; }

        [ForeignKey("Warehouse")]
        public Guid WarehouseId { get; set; }
        public virtual Warehouse? Warehouse { get; set; }

        public int Quantity { get; set; }
    }
}
