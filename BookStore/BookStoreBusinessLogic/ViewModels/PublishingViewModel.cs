using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class PublishingViewModel
    {
        public int ID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
    }
}
