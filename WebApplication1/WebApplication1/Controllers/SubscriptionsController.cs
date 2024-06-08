using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly SubscriptionsContext _context;
    }

    public SubscriptionsController(SubscriptionsContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AddPayment(AddPaymentRequest request)
    {

    }
}
