﻿using PunjabOrnaments.Service.APi.Data;
using PunjabOrnaments.Service.APi.DTOs.PurchaseDto;
using PunjabOrnaments.Service.APi.Entities.Purchase;
using PunjabOrnaments.Service.APi.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PunjabOrnaments.Service.APi.Controllers.ApprovalController
{
    public class ApprovalController : BaseApiController
    {
        public ApprovalController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }

        [HttpGet("Getallgoldpurchaserequests")]
        public async Task<ActionResult<IEnumerable<PurchaseRequest>>> Getallgoldpurchaserequests()
        {
            try
            {
                var result =  await _context.PurchaseRequests.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("GoldApprove/{id}")]
        public async Task<ActionResult<GoldPurchaseDTo>> GoldApprove(int id)
        {
            var goldPurchase = await _context.PurchaseRequests.FindAsync(id);
            if (goldPurchase != null)
            {
                goldPurchase.IsApproved = 1;
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

            goldPurchase.IsApproved = 0;
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
