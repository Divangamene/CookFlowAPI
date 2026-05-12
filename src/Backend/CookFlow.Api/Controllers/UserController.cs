using Microsoft.AspNetCore.Mvc;

namespace CookFlow.api.Controllers;

[Route("Api/[controller]")]
public class UserController : Controller
{
    [HttpPost]
    public IActionResult Register()
    {
        return Created();
    }
}
