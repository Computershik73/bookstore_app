using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Warehouse
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Capacity { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        [ForeignKey("WarehouseID")]
        public virtual List<BookWarehouse> BookWarehouses { get; set; }
    }
}
