using System.Collections.Generic;
using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class WarehouseViewModel
    {
        public int ID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Capacity")]
        public int Capacity { get; set; }
    }
}
