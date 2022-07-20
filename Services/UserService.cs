using AuthMicroservice.Controllers;

namespace AuthMicroservice.Services
{
    public class UserService : IUserService
    {
        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Admin") && model.Password.Equals("123456")) return true;
            else return false;
        }

        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "Admin", Password = "123456" };
        }
    }
}

