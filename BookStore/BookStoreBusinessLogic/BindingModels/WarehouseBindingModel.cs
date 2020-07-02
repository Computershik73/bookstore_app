namespace BookStoreBusinessLogic.BindingModels
{
    public class WarehouseBindingModel
    {
        public int? ID { get; set; }
        public int AddressID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
