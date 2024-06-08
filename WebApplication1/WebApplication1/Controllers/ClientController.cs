using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s19586_06.Context;
using s19586_06.Models;
using System.Threading.Tasks;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly SubscriptionsContext _context;

        public ClientController(SubscriptionsContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await _context.Clients
                .Include(sa => sa.Sales)
                    .ThenInclude(su => su.Subscriptions)
                .FirstOrDefaultAsync(c => c.IdClient == id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }
    }
}
