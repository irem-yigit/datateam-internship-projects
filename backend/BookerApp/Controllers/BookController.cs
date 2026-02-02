using Microsoft.AspNetCore.Mvc;
using BookerApp.Entities;
using System.Runtime.Versioning;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BookerApp.Data;

namespace BookerApp.Controllers;
[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public BookController(ApplicationDbContext context)
    {
        _context = context;
    }

    //Get all books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        var books = _context.Books.ToList();
        return Ok(books);
    }

    //Get book by id
    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound("Book not found");
        return Ok(book);
    }

    //Add a new book
    [HttpPost]
    public IActionResult CreateBook ([FromBody] Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetBookById),
            new { id = book.Id },
            book);
    }

    //Update a book
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book book)
    {
        var existingBook = _context.Books.Find(id);
        if (existingBook == null)
            return NotFound("Book not found");

        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.ISBN = book.ISBN;
        existingBook.PublicationYear = book.PublicationYear;

        _context.SaveChanges();
        return Ok(existingBook);
    }
    
    //Delete a book by id
    [HttpDelete("{id}")]    
    public IActionResult DeleteBook(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound("Book not found");

        _context.Books.Remove(book);
        _context.SaveChanges();
        return NoContent();
    }   

}