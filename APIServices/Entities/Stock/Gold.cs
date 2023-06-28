﻿using APIServices.Entities.Purchase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServices.Entities.Stock
{
    public class Gold
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Code { get; set; }
        public decimal? Weight { get; set; }
        public string? Brand { get; set; }
        public string? Carrot { get; set; }

        [ForeignKey(nameof(PurchaseRequest.PurchaseRequestId))]
        public virtual PurchaseRequest? PurchasedDetail { get; set; }
    }
}
