﻿using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared.Models
{
    public class StockVehicule
    {
        [Key]
        public int StockVId { get; set; }
        public int VehiculeId { get; set; }
        public int ProduitId { get; set; }
        public int Qte { get; set; }
    }
}
