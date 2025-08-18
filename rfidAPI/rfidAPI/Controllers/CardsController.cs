using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using rfidAPI.Data;
using rfidAPI.Models;
using System.Linq;

// rfidAPI/Controllers/CardsController.cs

using Microsoft.EntityFrameworkCore;
namespace rfidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly RfidDbContext _context;
        public CardsController(RfidDbContext context) => _context = context;

        // GET: api/cards
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var items = await _context.AuthorizedCards
                                      .OrderByDescending(c => c.Id)
                                      .ToListAsync();
            return Ok(items);
        }

        // GET: api/cards/{id}
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _context.AuthorizedCards.FindAsync(id);
            return item is null ? NotFound() : Ok(item);
        }

        // GET: api/cards/by-uid/{uid}
        [HttpGet("by-uid/{uid}")]
        public async Task<IActionResult> GetByUid(string uid)
        {
            var item = await _context.AuthorizedCards.FirstOrDefaultAsync(c => c.CardUID == uid);
            return item is null ? NotFound() : Ok(item);
        }

        // GET: api/cards/check/{uid}   -> returns { authorized: true/false }
        [HttpGet("check/{uid}")]
        public async Task<IActionResult> Check(string uid)
        {
            if (string.IsNullOrWhiteSpace(uid)) return BadRequest(new { authorized = false });
            bool exists = await _context.AuthorizedCards.AnyAsync(c => c.CardUID == uid);
            return Ok(new { authorized = exists });
        }

        // POST: api/cards
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] AuthorizedCard card)
        {
            // 1. Basic validation
            if (string.IsNullOrWhiteSpace(card.CardUID))
                return BadRequest("CardUID is required");

            // 2. Check if UID already exists
            bool exists = await _context.AuthorizedCards
                .AnyAsync(c => c.CardUID == card.CardUID);

            if (exists)
                return Conflict($"Card with UID {card.CardUID} already exists");

            // 3. Set CreatedAt automatically
            card.CreatedAt = DateTime.UtcNow;

            // 4. Save new card
            _context.AuthorizedCards.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllCards), new { id = card.Id }, card);
        }


        // PUT: api/cards/{id}  (only username change as an example)
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] AuthorizedCard input)
        {
            var card = await _context.AuthorizedCards.FindAsync(id);
            if (card is null) return NotFound();

            card.UserName = input.UserName ?? card.UserName;
            await _context.SaveChangesAsync();

            return Ok(card);
        }

        // DELETE: api/cards/{id}
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var card = await _context.AuthorizedCards.FindAsync(id);
            if (card is null) return NotFound();

            _context.AuthorizedCards.Remove(card);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/cards/by-uid/{uid}
        [HttpDelete("by-uid/{uid}")]
        public async Task<IActionResult> DeleteByUid(string uid)
        {
            var card = await _context.AuthorizedCards.FirstOrDefaultAsync(c => c.CardUID == uid);
            if (card is null) return NotFound();

            _context.AuthorizedCards.Remove(card);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

