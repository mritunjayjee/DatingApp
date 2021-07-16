using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string AddToken(AppUser user);
    }
}