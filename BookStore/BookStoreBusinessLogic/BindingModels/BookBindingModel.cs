namespace BookStoreBusinessLogic.BindingModels
{
    public class BookBindingModel
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }
        public decimal CostOfPurchase { get; set; }
        public decimal Price { get; set; }
        public int AuthorID { get; set; }
        public int PublishingID { get; set; }
    }
}
