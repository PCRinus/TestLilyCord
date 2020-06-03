using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLilyCord.Models;
using DataLibrary;
using DataLibrary.Business_Logic;
using DataLibrary.Data_Access;

namespace TestLilyCord.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }

        //public ActionResult ViewMedici()
        //{
        //    var data = MedicProcessor.LoadMedic();
        //    List<MedicModel> medici = new List<MedicModel>();

        //    foreach(var row in data)
        //    {
        //        medici.Add(new MedicModel
        //        {
        //            MedicID = row.MedicId,
        //            Email=row.Email,
        //            Nume=row.Nume,
        //            Prenume = row.Prenume
        //        });
        //    }

        //    return View(medici);
        //}
        //public ActionResult Signup_Medici()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Signup_Medici(MedicModel model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        int recordsCreated = MedicProcessor.CreateMedic(model.MedicID, model.Nume, model.Prenume, model.Email);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
    }
}