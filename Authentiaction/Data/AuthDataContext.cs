using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Data
{
    public class AuthDataContext(DbContextOptions<AuthDataContext> options) : IdentityDbContext(options)
    {
    }
}

// Default login. Username: string@string.com Password: String1!