using CookFlow.Communication.Request;

namespace CookFlow.Aplication.UseCases.User.Register;

 public class RegisterUserAccountUseCase
{
    public void Execute(RequestRegisterUserAccountJson request)
    {
        var validator= new RegisterUserAccountValidator();
        validator.Validate(request);
    }
}
