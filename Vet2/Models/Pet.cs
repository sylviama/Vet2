using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vet2.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        [Required]
        public string PetName { get; set; }
        public int HumanOwnerId { get; set; }
        public List<Vet> vets { get; set; }
        public int AnimalTypeId { get; set; }
    }
}