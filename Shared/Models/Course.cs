using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proxima.Shared.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Vous devez saisir l'adresse d'enlévement")]
        public string Adressenlevement { get; set; }
        [Required(ErrorMessage = "Vous devez saisir l'adresse de livraison")]
        public string Adresslivraison { get; set; }
    }
}
