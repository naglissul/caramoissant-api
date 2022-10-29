using CaramoissantApi.Data;
using CaramoissantApi.Infrastructure;
using CaramoissantApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CaramoissantApi.Commons;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<CaramoissantContext>(options =>
           options.UseSqlServer(defaultConnectionString));

        using (var scope = services.BuildServiceProvider().CreateScope())
        {
            var dataContext = scope.ServiceProvider.GetRequiredService<CaramoissantContext>();
            dataContext.Database.Migrate();
        }

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddScoped<ICaramoissantService, CaramoissantService>();

        return services;
    }
}
