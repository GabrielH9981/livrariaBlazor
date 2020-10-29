using crudBlazor.Server;
using Microsoft.AspNetCore.Mvc;
using crudBlazor.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CategoryController : Controller
{
    private readonly AppDbContext db;

    public CategoryController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var categories = await db.Categories.ToListAsync();
        return Ok(categories);
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
    public async Task<ActionResult> Post([FromBody] Category category)
    {
       
        try
        {
                var newCategory = new Category
                {
                    Nome = category.Nome
                };
        
            db.Add(newCategory);
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
    public async Task<ActionResult<Category>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var category = await db.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        db.Categories.Remove(category);
        await db.SaveChangesAsync();
        return Ok(category);
    }
}