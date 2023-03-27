using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class BookWritter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Gender { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<BookCover> BookCovers { get; set; }
    }
}
