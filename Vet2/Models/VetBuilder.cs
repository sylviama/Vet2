using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vet2.DAL;
using Vet2.Migrations;

namespace Vet2.Models
{
    public class VetBuilder
    {
        public Vet vet1 { get; set; }
        public Vet vet2 { get; set; }
        public Vet vet3 { get; set; }

        public Owner owner1 { get; set; }
        public Owner owner2 { get; set; }
        public Owner owner3 { get; set; }

        public AnimalType animalType1 { get; set; }
        public AnimalType animalType2 { get; set; }

        public Pet pet1 { get; set; }
        public Pet pet2 { get; set; }
        public Pet pet3 { get; set; }

        //public List<Pet> PetGenerator()
        //{
        //    vet1 = new Vet()
        //    {
        //        VetId = 1,
        //        VetFirstName = "Sylvia",
        //        VetLastName = "Ma"
        //    };
        //    vet2 = new Vet()
        //    {
        //        VetId = 2,
        //        VetFirstName = "Amanda",
        //        VetLastName = "Guan"
        //    };
        //    vet3 = new Vet()
        //    {
        //        VetId = 3,
        //        VetFirstName = "Chao",
        //        VetLastName = "Ma"
        //    };

        //    owner1=new Owner()
        //    {

        //    }
        //}
    }
}