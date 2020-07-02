using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDBImplementation.Models
{
    public class Publishing
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("PublishingID")]
        public virtual List<Book> Books { get; set; }
    }
}
