using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForceT.Shared.Models
{
    public class Vehicule
    {
        [Key]
        public int VehiculeId { get; set; }
        [Required(ErrorMessage = "Vous devez saisir le nom")]
        public string Nom { get; set; }
        [Range(typeof(int), "1", "48999", ErrorMessage = "Vous devez saisir le poid")]
        public int Poid { get; set; }
        [Required(ErrorMessage = "Vous devez saisir le matricule")]
        public string Matriculation { get; set; }
    }
}
