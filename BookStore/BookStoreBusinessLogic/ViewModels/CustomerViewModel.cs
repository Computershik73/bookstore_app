using System.ComponentModel;

namespace BookStoreBusinessLogic.ViewModels
{
    public class CustomerViewModel
    {
        public int ID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
    }
}
