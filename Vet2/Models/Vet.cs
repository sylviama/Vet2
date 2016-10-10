using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vet2.Models
{
    public class Vet
    {
        [Key]
        public int VetId { get; set; }
        [Required]
        public string VetFirstName { get; set; }
        [Required]
        public string VetLastName { get; set; }
    }
}