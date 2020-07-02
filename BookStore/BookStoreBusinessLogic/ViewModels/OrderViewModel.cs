using System.ComponentModel;
using System.Collections.Generic;
using System;
using BookStoreBusinessLogic.Enums;

namespace BookStoreBusinessLogic.ViewModels
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        [DisplayName("Customer")]
        public string CustomerName { get; set; }
        [DisplayName("Placement date")]
        public DateTime PlacementDate { get; set; }
        [DisplayName("Status")]
        public OrderStatus Status { get; set; }
        public Dictionary<int, (string, int)> Books { get; set; }
    }
}
