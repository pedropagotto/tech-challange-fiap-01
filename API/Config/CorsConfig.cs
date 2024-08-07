﻿using System.Diagnostics.CodeAnalysis;

namespace API.Config
{
    [ExcludeFromCodeCoverage]
    public static class CorsConfig
    {
        public static IServiceCollection AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .WithMethods("GET", "POST", "PUT", "DELETE")
                );
            });

            return services;
        }
    }
}
