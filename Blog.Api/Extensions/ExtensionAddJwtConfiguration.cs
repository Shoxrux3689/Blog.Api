﻿using Blog.Api.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Api.Extensions
{
    public static class ExtensionAddJwtConfiguration
    {
        public static void AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var section = configuration.GetSection(nameof(JwtOptions));
            services.Configure<JwtOptions>(section);

            JwtOptions jwtOptions = section.Get<JwtOptions>()!;

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    var signingKey = System.Text.Encoding.UTF32.GetBytes(jwtOptions.SigningKey);

                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = jwtOptions.ValidIssuer,
                        ValidAudience = jwtOptions.ValidAudience,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        IssuerSigningKey = new SymmetricSecurityKey(signingKey),
                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                });

        }
    }
}
