using Application.Configuration.Interfaces;
using Application.Interfaces.Services;
using Infraestructure.Configuration;
using Infraestructure.DbContext;
using Infraestructure.DbContext.Interface;
using Infraestructure.Queries.Usuario;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInyection
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddScoped<IUsuarioService, UsuarioQueryService>();
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<IProperties, Properties>();
        }
    }
}
