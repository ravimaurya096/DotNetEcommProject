using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string BookUrl { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public string ISBNNUMBER { get; set;} = string.Empty;

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile BookFile { get; set; }

        public int BookCoverId { get; set; }

        public BookCover BookCover { get; set; }
        
        public BookWritter BookWriter { get; set; }
    }
}
