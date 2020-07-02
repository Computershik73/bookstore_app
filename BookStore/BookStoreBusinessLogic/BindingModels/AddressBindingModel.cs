namespace BookStoreBusinessLogic.BindingModels
{
    public class AddressBindingModel
    {
        public int? ID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int ZipPostalCode { get; set; }
    }
}
