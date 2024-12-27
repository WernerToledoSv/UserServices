

using Application.Configuration.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infraestructure.Configuration
{
    public class Properties : IProperties
    {
        private readonly string _DbStringConnection;

        public Properties(IConfiguration configuration)
        {
            _DbStringConnection = configuration["ConexionPostgresdb"];
        }

        public string DbStringConnection => _DbStringConnection ?? string.Empty;
    }
}
