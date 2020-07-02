using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Address
    {
        public int ID { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Building { get; set; }
        [Required]
        public int ZipPostalCode { get; set; }
        [ForeignKey("AddressID")]
        public virtual List<Warehouse> Warehouses { get; set; }
    }
}
