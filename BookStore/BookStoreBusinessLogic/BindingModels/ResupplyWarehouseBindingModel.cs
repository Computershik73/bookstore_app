using System.Collections.Generic;

namespace BookStoreBusinessLogic.BindingModels
{
    public class ResupplyWarehouseBindingModel
    {
        public int WarehouseID { get; set; }
        public Dictionary<int, int> Books { get; set; }
    }
}
