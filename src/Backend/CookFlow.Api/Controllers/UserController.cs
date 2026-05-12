using CookFlow.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace CookFlow.api.Controllers;

[Route("api/[controller]")]
public class UserController : Controller
{

    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {
        return Created();
    }
}
