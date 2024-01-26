using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebhookExample.Models;

namespace WebhookExample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WebhookController : ControllerBase
{
    [HttpPost]
    public IActionResult HandleWebhookNotification([FromBody] WebhookPayload payload)
    {
        //do something, notify event subscribers, etc.
        Console.WriteLine(payload);


        return Ok();
    }
}
