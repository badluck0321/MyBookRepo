using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
public class BooksServices
{
    private AppDbContext _context;
    public BooksServices(AppDbContext context)
    {
        _context = context;
    }

    public void AddBook(BookDto bookdto){
        var book=new Book(){
            Title=bookdto.Title,
            Description=bookdto.Description,
            IsRead = bookdto.IsRead,
            DateRead = bookdto.DateRead,
            Rate = bookdto.Rate,
            Genre = bookdto.Genre,
            Author = bookdto.Author,
            CoverUrl = bookdto.CoverUrl,
            DateAdded = bookdto.DateAdded
        };
        _context.Add(book);
        _context.SaveChanges();
    }

    public List<Book> GetAllBooks(){
        var ListBooks=_context.books;
        return ListBooks.ToList();
    }

    public Task<Book> GetBook(int Idbook){
        var specBook=_context.books.FirstOrDefaultAsync(n=>n.Id==Idbook);
        return specBook;
    }
}



