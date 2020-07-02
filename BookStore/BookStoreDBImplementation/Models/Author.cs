using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [ForeignKey("AuthorID")]
        public virtual List<Book> Books { get; set; }
    }
}
