using crudBlazor.Server;
using Microsoft.AspNetCore.Mvc;
using crudBlazor.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class RentController : Controller
{
    private readonly AppDbContext db;

    public RentController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var rents = await db.Rents.ToListAsync();
        return Ok(rents);
    }

    //[HttpGet]
    //[Route("GetById")]
    //public async Task<IActionResult> Get([FromQuery] string id)
    //{
    //    var categoria = await db.Categories.SingleOrDefaultAsync(x => x.IdCategory == Convert.ToInt32(id));
    //        return Ok(categoria);
    //}

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] RentDto rent)
    {
        try
        {
                var newRent = new Rent
                {
                    nomeBiblioteca = rent.nomeBiblioteca,
                    BookId = Convert.ToInt32(rent.BookId),
                    UserId = Convert.ToInt32(rent.UserId)
                };
        
            db.Add(newRent);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }
}