using BookStoreBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        public DateTime PlacementDate { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("OrderID")]
        public virtual List<OrderBook> OrderBooks { get; set; }
    }
}
