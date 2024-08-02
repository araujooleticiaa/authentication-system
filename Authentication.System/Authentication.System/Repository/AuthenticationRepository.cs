using Authentication.System.Data;
using Authentication.System.Interface;
using Authentication.System.Model;
using Microsoft.EntityFrameworkCore;

namespace Authentication.System.Repository;

public class AuthenticationRepository : IAuthentication
{
    private DataContext _dataContext;

    public AuthenticationRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<Users> Login(Users user)
    {
        var newUser = _dataContext.User.Add(user);  
        await _dataContext.SaveChangesAsync();

        return user;
    }

    public Task<Users> Register()
    {
        return _dataContext.User.FirstOrDefaultAsync();
    }
}
