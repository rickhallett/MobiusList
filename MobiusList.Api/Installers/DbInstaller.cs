using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobiusList.Data;

namespace MobiusList.Api.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            {
                services.AddDbContext<MobiusDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("ProdDB"), x => x.MigrationsAssembly("MobiusList.Api")));
            }
            else
            {
                services.AddDbContext<MobiusDbContext>(options => 
                    options.UseSqlServer(configuration.GetConnectionString("DevDB"), x => x.MigrationsAssembly("MobiusList.Api")));
            }
            
            services.BuildServiceProvider().GetService<MobiusDbContext>().Database.Migrate();
        }
    }
}