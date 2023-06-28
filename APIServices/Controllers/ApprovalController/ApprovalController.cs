using APIServices.Data;
using APIServices.DTOs.PurchaseDto;
using APIServices.Entities.Purchase;
using APIServices.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIServices.Controllers.ApprovalController
{
    public class ApprovalController : BaseApiController
    {
        public ApprovalController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        [HttpGet("Getallgoldpurchaserequests")]
        public async Task<ActionResult<IEnumerable<PurchaseRequest>>> Getallgoldpurchaserequests()
        {
            return await _context.PurchaseRequests.ToListAsync();
        }

        [HttpPut("GoldApprove/{id}")]
        public async Task<ActionResult<GoldPurchaseDTo>> GoldApprove(int id)
        {
            var goldPurchase = await _context.PurchaseRequests.FindAsync(id);
            if (goldPurchase != null)
            {
                goldPurchase.IsApproved = true;
                _context.PurchaseRequests.Update(goldPurchase);
                await _context.SaveChangesAsync();

                return new GoldPurchaseDTo
                {
                    PurchaseRequestId = goldPurchase.PurchaseRequestId,
                    MatelType = goldPurchase.MatelType,
                    ItemType = goldPurchase.ItemType,
                    Brand = goldPurchase.Brand,
                    ManufactureId = goldPurchase.ManufactureId,
                    ManufactureName = goldPurchase.ManufactureName,
                    GrossWeight = goldPurchase.GrossWeight,
                    LessWeight = goldPurchase.LessWeight,
                    NetWeight = goldPurchase.NetWeight,
                    Quantity = goldPurchase.Quantity,
                    Rate = goldPurchase.Rate,
                    Wastage = goldPurchase.Wastage,
                    Labour = goldPurchase.Labour,
                    PurchaseDate = goldPurchase.PurchaseDate
                };
            }
            return BadRequest("Item Doesnot exist");
        }

        [HttpPut("GoldReject/{id}")]
        public async Task<ActionResult<GoldPurchaseDTo>> GoldReject(int id)
        {
            var goldPurchase = await _context.PurchaseRequests.FindAsync(id);
            if (goldPurchase == null)
                return BadRequest("Item Doesnot exist");

            goldPurchase.IsApproved = false;
            _context.PurchaseRequests.Update(goldPurchase);
            await _context.SaveChangesAsync();
            
            return new GoldPurchaseDTo
            {
                Message = "Delete Sucess",
                PurchaseRequestId = goldPurchase.PurchaseRequestId,
                MatelType = goldPurchase.MatelType,
                ItemType = goldPurchase.ItemType,
                Brand = goldPurchase.Brand,
                ManufactureId = goldPurchase.ManufactureId,
                ManufactureName = goldPurchase.ManufactureName,
                GrossWeight = goldPurchase.GrossWeight,
                LessWeight = goldPurchase.LessWeight,
                NetWeight = goldPurchase.NetWeight,
                Quantity = goldPurchase.Quantity,
                Rate = goldPurchase.Rate,
                Wastage = goldPurchase.Wastage,
                Labour = goldPurchase.Labour,
                PurchaseDate = goldPurchase.PurchaseDate
            };
        }
    }
}
