using PunjabOrnaments.Service.APi.Data;
using PunjabOrnaments.Service.APi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace PunjabOrnaments.Service.APi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        public readonly DataContext _context;
        public readonly ITokenService _tokenService;

        public BaseApiController(DataContext context, ITokenService tokenService)
        {
            this._context = context;
            this._tokenService = tokenService;
        }
    }
}
