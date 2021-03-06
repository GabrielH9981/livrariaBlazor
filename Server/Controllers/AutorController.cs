using crudBlazor.Server;
using Microsoft.AspNetCore.Mvc;
using crudBlazor.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class AutorController : Controller
{
    private readonly AppDbContext db;

    public AutorController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var autors = await db.Autors.ToListAsync();
        return Ok(autors);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var autor = await db.Autors.SingleOrDefaultAsync(x => x.AutorId == Convert.ToInt32(id));
        return Ok(autor);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Autor autor)
    {
        try
        {
            var newAutor = new Autor
            {
                Nome = autor.Nome
            };

            db.Add(newAutor);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult<Autor>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var autor = await db.Autors.FindAsync(id);
        if (autor == null)
        {
            return NotFound();
        }
        db.Autors.Remove(autor);
        await db.SaveChangesAsync();
        return Ok(autor);
    }
}