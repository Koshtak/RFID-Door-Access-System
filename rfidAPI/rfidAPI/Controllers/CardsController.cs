using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rfidAPI.Data;

namespace rfidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly RfidDbContext _context;
        public CardsController(RfidDbContext context) => _context = context;

        // GET: api/cards/check/{kid}
        [HttpGet("check/{kid}")]
        public async Task<IActionResult> Check(string kid)
        {
            if (string.IsNullOrWhiteSpace(kid))
                return BadRequest(new { authorized = false });

            var card = await _context.Cards.FirstOrDefaultAsync(c => c.KID == kid);
            if (card is null)
                return Ok(new { authorized = false });

            return Ok(new { authorized = card.Yetki });
        }
    }
}
