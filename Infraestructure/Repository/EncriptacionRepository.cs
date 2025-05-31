
using Application.Configuration.Interfaces;
using Application.Interfaces.Services;
using Sodium;
using System.Text;

namespace Infraestructure.Repository
{
    class EncriptacionRepository : IEncriptacionService
    {
        private readonly string _claveSecreta;
        private readonly string _nonce;

        public EncriptacionRepository(IProperties properties)
        {
            _claveSecreta = properties.EncrypKey;
            _nonce = properties.Nonce;
        }

        public string Desencriptar(string text)
        {
            byte[] data = Convert.FromBase64String(text);

            byte[] key = Encoding.UTF8.GetBytes(_claveSecreta);

            byte[] nonce = Encoding.UTF8.GetBytes(_nonce);

            byte[] decryptedBytes = SecretBox.Open(data, nonce, key);

            // Convertimos el resultado desencriptado a un string
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        public string Encriptar(string text)
        {
            // Convertir el texto plano a bytes
            byte[] data = Encoding.UTF8.GetBytes(text);

            byte[] key = Encoding.UTF8.GetBytes(_claveSecreta);

            byte[] nonce = Encoding.UTF8.GetBytes(_nonce);

            // Cifrar el texto utilizando la clave
            byte[] cipherText = SecretBox.Create(data, nonce, key);

            return Convert.ToBase64String(cipherText);
        }
    }
}
