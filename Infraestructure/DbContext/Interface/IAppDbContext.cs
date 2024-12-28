

using System.Data;

namespace Infraestructure.DbContext.Interface
{
    public interface IAppDbContext
    {
        IDbConnection ObtenerConexion();
    }
}
