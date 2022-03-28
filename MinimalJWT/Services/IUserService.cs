using MinimalJWT.Models;

namespace MinimalJWT.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
