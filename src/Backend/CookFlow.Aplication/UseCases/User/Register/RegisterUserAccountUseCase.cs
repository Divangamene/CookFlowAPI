using CookFlow.Communication.Request;
using Mapster;
using System.Security.Cryptography.X509Certificates;

namespace CookFlow.Aplication.UseCases.User.Register;

 public class RegisterUserAccountUseCase
{
    public void Execute(RequestRegisterUserAccountJson request)
    {
        var validator= new RegisterUserAccountValidator();
         var  result=validator.Validate(request);
        var user = request.Adapt<CookFLow.Domain.Entities.User>();
       
    }
}
