using Microsoft.AspNetCore.Mvc;
using FactoryQuest.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace FactoryQuest.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly GameDbContext _db;

        public PlayerController(GameDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetPlayer()
        {
            var player = _db.Players.FirstOrDefault();

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }


        [HttpPost("{id}/explore")]
        public async Task<IActionResult> Explore(int id)
        {
            var player = await _db.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            player.Experience += 10;
            player.Gold += 20;

            await _db.SaveChangesAsync();

            return Ok(player);
        }
    }
}