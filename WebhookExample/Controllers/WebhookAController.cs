using Microsoft.AspNetCore.Mvc;
using WebhookExample.Core.Abstractions;
using WebhookExample.Core.Models;

namespace WebhookExample.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WebhookAController : ControllerBase
{
    private readonly IWebhookProcessingService<PayloadA> _service;
    public WebhookAController(IWebhookProcessingService<PayloadA> service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult HandleWebhookNotification([FromBody] PayloadA payload)
    {
        try
        {
            return _service.Process(payload) ? NoContent() : BadRequest(); //possibly more to do if failure
        }
        catch (Exception ex)
        {
            //log and handle here
            return Problem(); //check docs to see if anything needs to be returned here since it's a webhook
        }
    }
}
