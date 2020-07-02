using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class AddressViewModel
    {
        public int ID { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("Building")]
        public string Building { get; set; }  
        [DisplayName("Postal Code")]
        public int ZipPostalCode { get; set; }
    }
}
