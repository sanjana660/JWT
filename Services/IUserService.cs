using AuthMicroservice.Controllers;

namespace AuthMicroservice.Services
{
    public interface IUserService
        {
            bool IsValidUserInformation(LoginModel model);
            LoginModel GetUserDetails();
        }
}
