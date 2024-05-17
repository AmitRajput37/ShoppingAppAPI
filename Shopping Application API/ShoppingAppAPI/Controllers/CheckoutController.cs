using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingAppAPI.Models;

namespace ShoppingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> ProcessOrder([FromBody] Order order)
        {
            // Process the order (e.g., save to database, send confirmation email, etc.)

            // Return a confirmation message
            return Ok("Order processed successfully. Order ID: " + order.OrderId);
        }
    }
}
