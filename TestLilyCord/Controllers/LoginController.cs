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
    public class LoginController : Controller
    {
        public ActionResult FormLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FormLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //int recordsCreated = LoginProcessor.CreateLogin(model.Email, model.Parola);
                return RedirectToAction("ViewPacient", "Pacient", new { area = "" });
            }
            return View();
        }

        public ActionResult ViewLogin()
        {
            var data = LoginProcessor.LoadLogin();
            List<LoginModel> login = new List<LoginModel>();

            foreach (var row in data)
            {
                login.Add(new LoginModel
                {
                    Email = row.Email,
                    Parola = row.Parola
                });
            }

            return View(login);
        }

        public ActionResult FormRegister()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FormRegister(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = LoginProcessor.CreateLogin(model.Email, model.Parola);
                return RedirectToAction("Success", "Home", new { area = "" });
            }
            else
            {
                return RedirectToAction("Failure", "Home", new { area = "" });
            }
            return View();
        }
    }
}