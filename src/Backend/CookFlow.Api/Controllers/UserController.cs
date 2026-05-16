using CookFlow.Aplication.UseCases.User.Register;
using CookFlow.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace CookFlow.api.Controllers;

[Route("Api/[controller]")]
public class UserController : Controller
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
    {
        var UseCase = new RegisterUserAccountUseCase();
        UseCase.Execute(request);

        return Created();
    }
}