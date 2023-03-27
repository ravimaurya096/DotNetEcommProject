using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class BookCover
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public ICollection<Book> Books { get;}
    }
}
