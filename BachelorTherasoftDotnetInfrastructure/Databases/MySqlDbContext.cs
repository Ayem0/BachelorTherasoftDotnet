using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BachelorTherasoftDotnetDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BachelorTherasoftDotnetInfrastructure.Databases;

public class MySqlDbContext : IdentityDbContext<User, Role, string>
{
     public MySqlDbContext(DbContextOptions options) : base(options)
    {
    }
}
