using ecommerce_Project.Context;
using ecommerce_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ECommerceContext _context;

    public ProductsController(ECommerceContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Products>> PostProduct(Products product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Products>> UpdateProduct(long id, Products products)
    {

        if (id != products.Id)
        {
            return BadRequest();
        }
        _context.Entry(products).State = EntityState.Modified;
        
            await _context.SaveChangesAsync();
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var productId = await _context.Products.FindAsync(id);
        if (productId == null)
        {
            return NotFound();
        }
        _context.Products.Remove(productId);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
