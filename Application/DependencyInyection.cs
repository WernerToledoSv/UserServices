using Application.UseCase;
using Application.UseCase.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInyection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            services.AddScoped<IUsuarioUseCase, UsuarioUseCase>();
            services.AddScoped<IRolUseCase, RolUseCase>();
            services.AddScoped<ILugarUseCase, LugarUseCase>();
            services.AddScoped<IMisionUseCase, MisionUseCase>();
            services.AddScoped<IUnionMisionLugarUseCase, UnionMisionLugarUseCase>();
        }
    }
}
