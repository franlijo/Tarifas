using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tarifaAPI.Data;
using tarifaAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class TarifasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarifasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tarifa>>> GetTarifas()
    {
        return await _context.Tarifas.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Tarifa>> PostTarifa(Tarifa tarifa)
    {
        _context.Tarifas.Add(tarifa);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetTarifa", new { id = tarifa.Id }, tarifa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTarifa(int id, Tarifa tarifa)
    {
        if (id != tarifa.Id)
            return BadRequest();

        _context.Entry(tarifa).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarifa(int id)
    {
        var tarifa = await _context.Tarifas.FindAsync(id);
        if (tarifa == null)
            return NotFound();

        _context.Tarifas.Remove(tarifa);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
