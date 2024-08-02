using Authentication.System.Model;

namespace Authentication.System.Interface
{
    public interface IAuthentication
    {
        Task<Users> Login(Users user);
        Task<Users> Register();
    }
}
