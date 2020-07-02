using BookStoreBusinessLogic.Enums;
using System;
using System.Collections.Generic;

namespace BookStoreBusinessLogic.BindingModels
{
    public class OrderBindingModel
    {
        public int? ID { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime PlacementDate { get; set; }
        public int CustomerID { get; set; }
        public Dictionary<int, (string, int)> Books { get; set; }
    }
}
