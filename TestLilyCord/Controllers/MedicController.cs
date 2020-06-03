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
    public class MedicController : Controller
    {
        public ActionResult ViewMedici()
        {
            var data = MedicProcessor.LoadMedic();
            List<MedicModel> medici = new List<MedicModel>();

            foreach (var row in data)
            {
                medici.Add(new MedicModel
                {
                    //id=row.Id,
                    MedicID = row.MedicId,
                    Nume = row.Nume,
                    Prenume = row.Prenume,
                    Email = row.Email,
                    Grad_profesional=row.Grad_profesional,
                    Telefon=row.Telefon,
                    Specializare=row.Specializare
                });
            }

            return View(medici);
        }
        public ActionResult Signup_Medici()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup_Medici(MedicModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = MedicProcessor.CreateMedic(model.MedicID, model.Nume, model.Prenume, model.Email, model.Grad_profesional, model.Telefon, model.Specializare);
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }
    }
}