using crudBlazor.Server;
using Microsoft.AspNetCore.Mvc;
using crudBlazor.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class BookAutorController : Controller
{
    private readonly AppDbContext db;

    public BookAutorController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var bookAutor = await db.BookAutors.ToListAsync();
        return Ok(bookAutor);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var bookAutor = await db.BookAutors.SingleOrDefaultAsync(x => x.BookId == Convert.ToInt32(id));
            return Ok(bookAutor);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] BookAutorDto bookAutor)
    {
        try
        {
            var newBookAutor = new BookAutor
            {
                BookId = Convert.ToInt32(bookAutor.BookId),
                AutorId = Convert.ToInt32(bookAutor.AutorId)
            };

            db.Add(newBookAutor);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }
}