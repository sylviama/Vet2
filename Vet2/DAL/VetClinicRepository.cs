using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vet2.Models;
using System.Data.Entity;
using Vet2.Migrations;

namespace Vet2.DAL
{
    public class VetClinicRepository
    {
        public VetClinicContext Context { get; set; }

        public VetClinicRepository()
        {
            Context = new VetClinicContext();
        }

        public VetClinicRepository(VetClinicContext _context)
        {
            Context = _context;
        }
        //create
        //update
        //read
        public List<Pet> returnPet()
        {
            return Context.petTable.ToList();
        }
        //delete
    }
}