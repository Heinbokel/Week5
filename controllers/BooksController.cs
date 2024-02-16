using Microsoft.AspNetCore.Mvc;
using Week5.models;
using Week5.models.requests;

namespace Week5.controllers {


    [ApiController]
    [Route("[controller]")]
    public class BooksController: ControllerBase {
        private static List<Book> BOOKS = new List<Book>
        {
            new Book{BookId = "1", AuthorId = "1", Genre = "Fiction", Title = "The Little Prince"},
            new Book{BookId = "2", AuthorId = "2", Genre = "Fiction", Title = "The Road"},
            new Book{BookId = "3", AuthorId = "2", Genre = "Fiction", Title = "No Country For Old Men"}
        };

        [HttpGet("", Name = "GetBooks")]
        public List<Book> GetBooks() {
            return BOOKS;
        }

        [HttpGet("{bookId}", Name = "GetBookById")]
        public Book? GetBookById(string bookId) {
            return BOOKS.Find(book => book.BookId == bookId);
        }

        [HttpPost("", Name = "PostBook")]
        public Book PostBook(BookCreateRequest request) {
            Book bookToSave = new Book { 
                BookId = (BOOKS.Count + 1).ToString(),
                Title = request.Title,
                Genre = request.Genre,
                AuthorId = request.AuthorId
            };

            BOOKS.Add(bookToSave);
            return bookToSave;
        }
    }

}