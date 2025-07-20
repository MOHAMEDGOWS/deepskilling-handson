using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SecureDataController : ControllerBase
{
    [Authorize]
    [HttpGet("secret")]
    public IActionResult GetSecret()
    {
        return Ok("This is protected data!");
    }
}
