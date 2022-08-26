using CatalogoMinimalAPI.Models;

namespace CatalogoMinimalAPI.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer, string audience, UserModel user);
    }
}
