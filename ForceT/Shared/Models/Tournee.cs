using System;
using System.ComponentModel.DataAnnotations;

namespace ForceT.Shared.Models
{
    public class Tournee
    {
        [Key]
        public int TourneeId { get; set; }
        [Required(ErrorMessage = "Vous devez saisir un libellé pour la tournée")]
        public string Libellé { get; set; }
        [Required(ErrorMessage = "Vous devez saisir la date de la tournée")]
        public DateTime Date_tournee { get; set; }
        public int LivreurId { get; set; }
        public int VehiculeId { get; set; }
        public string Type { get; set; }
        public int Agenceid { get; set; }
    }
}
