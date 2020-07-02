using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class BookViewModel
    {
        public int ID { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Pub. Year")]
        public int PublicationYear { get; set; }
        [DisplayName("Genre")]
        public string Genre { get; set; }
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [DisplayName("Cost")]
        public decimal CostOfPurchase { get; set; }
        [DisplayName("Author")]
        public string Author { get; set; }
        [DisplayName("Pub. House")]
        public string Publishing { get; set; }
    }
}
