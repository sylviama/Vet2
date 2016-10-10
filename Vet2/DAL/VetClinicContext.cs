using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vet2.Models;

namespace Vet2.DAL
{
    public class VetClinicContext: DbContext
    {
        public virtual DbSet<AnimalType> animalTypeTable { get; set; }
        public virtual DbSet<Owner> ownerTable { get; set; }
        public virtual DbSet<Pet> petTable { get; set; }
        public virtual DbSet<Vet> vetTable { get; set; }
    }
}