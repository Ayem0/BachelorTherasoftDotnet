using System;
using BachelorTherasoftDotnetDomain.Entities;
using BachelorTherasoftDotnetInfrastructure.Databases;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;

namespace BachelorTherasoftDotnetApplication.Services;

public static class ServicesRegistration
{
    public static void AddMySqlDbContext(this IServiceCollection services, IConfiguration configuration) {
        services.AddDbContext<MySqlDbContext>(options => options.UseMySql(new MySqlConnection(configuration.GetConnectionString("MySQL")), new MySqlServerVersion(new Version(8, 0, 38))));
    }
    public static void AddIdentity(this IServiceCollection services) {
        services.AddIdentity<User, Role>(options => {
           options.SignIn.RequireConfirmedEmail = true;
            options.User.RequireUniqueEmail = true;
            options.User.AllowedUserNameCharacters = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN0123456789";
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 10;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Lockout.MaxFailedAccessAttempts = 5;
        })
        .AddEntityFrameworkStores<MySqlDbContext>()
        .AddDefaultTokenProviders();
    }
}
