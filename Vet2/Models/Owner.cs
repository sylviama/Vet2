using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vet2.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Required]
        public string ownerFirstName { get; set; }
        [Required]
        public string ownerLastName { get; set; }
    }
}