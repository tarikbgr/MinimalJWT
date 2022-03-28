using MinimalJWT.Models;

namespace MinimalJWT.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke",Surname = "Rogers", Role = "Administrator"},
            new() { Username = "lydia_standart", EmailAddress = "lydia.standart@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" }
        };
    }
}
