using System.ComponentModel.DataAnnotations;

namespace BookStoreDBImplementation.Models
{
    public class BookWarehouse
    {
        public int ID { get; set; }
        [Required]
        public int Count { get; set; }
        public int BookID { get; set; }
        public int WarehouseID { get; set; }
        public virtual Book Book { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
