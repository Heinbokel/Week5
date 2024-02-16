using System.ComponentModel.DataAnnotations;

namespace Week5.models.requests {

    public class BookCreateRequest {

        [Required(ErrorMessage = "Author ID is required")]
        public string AuthorId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(1, ErrorMessage = "Title must be at least 1 character")]
        [MaxLength(100, ErrorMessage = "Title must be less than 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [MinLength(1, ErrorMessage = "Genre must be at least 1 character")]
        [MaxLength(100, ErrorMessage = "Genre must be less than 100 characters")]
        public string Genre { get; set; }

    }

}