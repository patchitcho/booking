using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proxima.Shared.Models
{
    public class Adresse
    {
        [Key]
        public int AdresseId { get; set; }
        [Required(ErrorMessage = "Vous devez saisir la societé")]
        public string Societé { get; set; }
        [Required(ErrorMessage = "Vous devez saisir le nom")]
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Vous devez saisir n° de téléphone")]
        public int Telephone { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Vous devez saisir l'adresse")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Vous devez saisir la ville")]
        public string Ville { get; set; }
        [Range(typeof(int), "1000", "48999", ErrorMessage = "Vous devez saisir une valeur entre 1000 et 48999")]
        public int Codepostale { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Agenceid { get; set; }
        public string Commentaire { get; set; }
        public string Type { get; set; }
    }
}
