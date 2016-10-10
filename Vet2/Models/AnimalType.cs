using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vet2.Models
{
    public class AnimalType
    {
        [Key]
        public int AnimalTypeId { get; set; }
        [Required]
        public string AnimalTypeName { get; set; }
    }
}