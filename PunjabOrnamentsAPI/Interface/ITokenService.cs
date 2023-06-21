using PunjabOrnamentsAPI.Entities;

namespace PunjabOrnamentsAPI.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
