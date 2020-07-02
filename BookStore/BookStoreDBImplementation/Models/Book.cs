using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int PublicationYear { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public decimal CostOfPurchase { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int AuthorID { get; set; }
        public int PublishingID { get; set; }
        public virtual Author Author { get; set; }
        public virtual Publishing Publishing { get; set; }
        [ForeignKey("BookID")]
        public virtual List<BookWarehouse> BookWarehouses { get; set; }
        [ForeignKey("BookID")]
        public virtual List<OrderBook> OrderBooks { get; set; }
    }
}
