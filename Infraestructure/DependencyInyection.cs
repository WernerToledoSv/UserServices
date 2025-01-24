using Application.Configuration.Interfaces;
using Application.Interfaces.Services;
using Infraestructure.Configuration;
using Infraestructure.DbContext;
using Infraestructure.DbContext.Interface;
using Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInyection
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            #region Servicios
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IRolService, RolService>();
            services.AddScoped<ILugarService, LugarService>();
            #endregion

            #region Base de datos
            services.AddScoped<IAppDbContext, AppDbContext>();
            #endregion

            services.AddScoped<IProperties, Properties>();
        }
    }
}
