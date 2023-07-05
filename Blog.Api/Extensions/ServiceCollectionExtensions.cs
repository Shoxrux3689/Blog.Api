using Blog.Api.Context;
using Blog.Api.Managers;
using Blog.Api.Managers.Interfaces;
using Blog.Api.Providers;
using Blog.Api.Repositories;
using Blog.Api.Repositories.Interfaces;

namespace Blog.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddJwtConfiguration(configuration);
        services.AddScoped<JwtTokenManager>();
        services.AddScoped<IUserManager, UserManager>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<UserProvider>();
        services.AddHttpContextAccessor();
    }

    /* dockerda ishlatish uchun kere boladi
    public static void MigrateIdentityDb(this WebApplication app)
    {
        if (app.Services.GetService<AppDbContext>() != null)
        {
            var identityDb = app.Services.GetRequiredService<AppDbContext>();
            identityDb.Database.Migrate();
        }
    }*/
}
