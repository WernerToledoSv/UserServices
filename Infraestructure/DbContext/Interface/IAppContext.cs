

using System.Data;

namespace Infraestructure.DbContext.Interface
{
    public interface IAppContext
    {
        IDbConnection ObtenerConexion();
    }
}
