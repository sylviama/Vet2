using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vet2.DAL;
using Vet2.Models;
using Vet2.Migrations;

namespace Vet2.Controllers
{
    public class PetController : Controller
    {

        // GET: Pet
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Search()
        {
            VetClinicContext context = new VetClinicContext();
            var products = context.petTable;
            //ViewBag.message = "this is the message.";
            return View(products);
        }

        //public ActionResult PetView()
        //{
        //    ViewBag.Pets = "pets";
        //    //ViewBag.Pets = _vetRepo.returnPet();
        //    return View();
        //}
    }
}