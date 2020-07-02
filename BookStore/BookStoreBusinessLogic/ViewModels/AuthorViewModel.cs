using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class AuthorViewModel
    {
        public int ID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
