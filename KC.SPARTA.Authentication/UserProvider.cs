using KC.SPARTA.Interface.Service;
using KC.SPARTA.Model.Model;
using KC.SPARTA.Common.Constants;
namespace KC.SPARTA.Authentication
{
    public class UserProvider : IUserProvider
    {
        public IAppUser GetUserContext(string UserId)
        {
            return new AppUser() { Name = UserId , Region = AppConstants.Region.APAC };
        }

        public bool Validate(string Name, string Password)
        {
            return true;
        }
    }
}
