
using Application.Feature.Lugar.Commands;
using Domain.Entities.Services.Lugar;

namespace Application.Interfaces.Services
{
    public interface ILugarService
    {
        Task<LugarResponse> AgregarLugar(AgregarLugarCommand rq);
        Task<LugarResponse> ActualizarLugar(ActualizarLugarCommand rq);
        Task<LugarResponse> EliminarLugar(EliminarLugarCommand rq);
        Task<LugarResponse> BuscarLugarById();
        Task<IList<LugarResponse>> BuscarLugarByNombre();
        Task<IList<LugarResponse>> ObtenerLugar();
        Task<LugarResponse> ActivarLugar(ActivarLugarCommand rq);

    }
}
