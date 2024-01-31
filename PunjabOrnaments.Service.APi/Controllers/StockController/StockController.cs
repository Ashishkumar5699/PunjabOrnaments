using PunjabOrnaments.Service.APi.Data;
using PunjabOrnaments.Service.APi.DTOs.StockDto;
using PunjabOrnaments.Service.APi.Entities.Stock;
using PunjabOrnaments.Service.APi.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnaments.Service.APi.Controllers.StockController
{
    //[Authorize]
    [AllowAnonymous]
    public class StockController : BaseApiController
    {
        public StockController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gold>>> GetAllStock()
        {
            return await _context.GoldStock.ToListAsync();
        }

        [HttpPost]
        public ActionResult<Gold> AddGold(GoldDto goldDto)
        {
            return BadRequest("Api is under construction please try after some time");
        }

    }
}
