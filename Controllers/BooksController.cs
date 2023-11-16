using Microsoft.AspNetCore.Mvc;

namespace MyBooks.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{

    public readonly BooksServices _booksServices;
    public BooksController(BooksServices booksService)
    {
        _booksServices = booksService;
    }

    [HttpPost]
    public IActionResult AddBook(BookDto bookDto){
        _booksServices.AddBook(bookDto);
        return Ok();
    }

}