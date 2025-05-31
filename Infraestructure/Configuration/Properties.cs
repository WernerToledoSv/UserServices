


namespace Infraestructure.Configuration
{
    using Application.Configuration.Interfaces;
    using Microsoft.Extensions.Configuration;

    public class Properties : IProperties
    {
        private readonly string _DbStringConnection;
        private readonly string _EncrypKey;
        private readonly string _LogFilePath;
        private readonly string _nonce;


        public Properties(IConfiguration configuration)
        {
            _DbStringConnection = configuration["ConexionPostgresdb"];
            _EncrypKey = configuration["Encritacion:key"];
            _nonce = configuration["Encritacion:nonce"];
        }

        public string DbStringConnection => _DbStringConnection ?? string.Empty;

        public string EncrypKey => _EncrypKey ?? string.Empty;

        public string Nonce => _nonce ?? string.Empty;
    }
}
