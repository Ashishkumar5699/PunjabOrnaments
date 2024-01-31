using PunjabOrnaments.Service.APi.Entities;

namespace PunjabOrnaments.Service.APi.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
