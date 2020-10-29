using crudBlazor.Server;
using Microsoft.AspNetCore.Mvc;
using crudBlazor.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class BookController : Controller
{
    private readonly AppDbContext db;

    public BookController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var book = await db.Books.ToListAsync();
        return Ok(book);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var book = await db.Books.SingleOrDefaultAsync(x => x.BookId == Convert.ToInt32(id));
            return Ok(book);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] BookDto book)
    {
        try
        {
            var newBook = new Book
            {
                Titulo = book.Titulo,
                Sinopse = book.Sinopse,
                CategoryId = Convert.ToInt32(book.CategoryId)
            };

            db.Add(newBook);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Book book)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        db.Entry(book).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<Book>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var book = await db.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        db.Books.Remove(book);
        await db.SaveChangesAsync();
        return Ok(book);
    }
}
