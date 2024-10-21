using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollectionApi.Models;

namespace CollectionApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CollectionItemsController : ControllerBase
{
    private readonly CollectionContext _context;

    public CollectionItemsController(CollectionContext context)
    {
        _context = context;
    }

    // GET: api/CollectionItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CollectionItemDTO>>> GetCollectionItems()
    {
        return await _context.CollectionItems
            .Select(x => ItemToDTO(x))
            .ToListAsync();
    }

    // GET: api/CollectionItems/5
    // <snippet_GetByID>
    [HttpGet("{id}")]
    public async Task<ActionResult<CollectionItemDTO>> GetCollectionItem(long id)
    {
        var collectionItem = await _context.CollectionItems.FindAsync(id);

        if (collectionItem == null)
        {
            return NotFound();
        }

        return ItemToDTO(collectionItem);
    }
    // </snippet_GetByID>

    // PUT: api/CollectionItems/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Update>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCollectionItem(long id, CollectionItemDTO collectionDTO)
    {
        if (id != collectionDTO.Id)
        {
            return BadRequest();
        }

        var collectionItem = await _context.CollectionItems.FindAsync(id);
        if (collectionItem == null)
        {
            return NotFound();
        }

        collectionItem.Title = collectionDTO.Title;
        collectionItem.Artist = collectionDTO.Artist;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!CollectionItemExists(id))
        {
            return NotFound();
        }

        return NoContent();
    }
    // </snippet_Update>

    // POST: api/CollectionItems
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Create>
    [HttpPost]
    public async Task<ActionResult<CollectionItemDTO>> PostCollectionItem(CollectionItemDTO collectionDTO)
    {
        var collectionItem = new CollectionItem
        {
            Artist = collectionDTO.Artist,
            Title = collectionDTO.Title
        };

        _context.CollectionItems.Add(collectionItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetCollectionItem),
            new { id = collectionItem.Id },
            ItemToDTO(collectionItem));
    }
    // </snippet_Create>

    // DELETE: api/CollectionItems/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCollectionItem(long id)
    {
        var collectionItem = await _context.CollectionItems.FindAsync(id);
        if (collectionItem == null)
        {
            return NotFound();
        }

        _context.CollectionItems.Remove(collectionItem);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CollectionItemExists(long id)
    {
        return _context.CollectionItems.Any(e => e.Id == id);
    }

    private static CollectionItemDTO ItemToDTO(CollectionItem collectionItem) =>
       new CollectionItemDTO
       {
           Id = collectionItem.Id,
           Title = collectionItem.Title,
           Artist = collectionItem.Artist
       };
}