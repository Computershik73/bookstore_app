using System.ComponentModel.DataAnnotations;

namespace BookStoreDBImplementation.Models
{
    public class OrderBook
    {
        public int ID { get; set; }
        [Required]
        public int Count { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}
