
namespace Application.Interfaces.Services
{
    public interface IEncriptacionService
    {
        public string Encriptar(string text);
        public string Desencriptar(string text);
    }
}
