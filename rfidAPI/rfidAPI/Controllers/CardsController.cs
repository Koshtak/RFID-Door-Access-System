using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using rfidAPI.Data;
using rfidAPI.Models;
using System.Linq;

namespace rfidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly RfidDbContext _context;

        public CardsController (RfidDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCards()
        {
            return Ok(_context.AuthorizedCards.ToList());
        }
        [HttpPost]
        public IActionResult AddCard(AuthorizedCard card)
        {
            _context.AuthorizedCards.Add(card);
            _context.SaveChanges();
            return Ok(card);
        }
    }
}
