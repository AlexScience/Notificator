using Microsoft.AspNetCore.Mvc;
using Notificator.Models;

namespace Notificator.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    [HttpPost("/send")]
    public IActionResult Send([FromBody] MediaEvent mediaEvent)
    {
        return Ok();
    }
}