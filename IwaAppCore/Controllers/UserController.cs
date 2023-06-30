using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IwaAppCore.Controllers;

[ApiController]
[Route("/user")]
public class UserController : ControllerBase
{

    [HttpGet]
    [Authorize]
    public String? GetUser() {
        return $"IWA on .NET Core\nUsername: {User.Identity?.Name}";
    }
    
}