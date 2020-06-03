using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLilyCord.Models;
using DataLibrary;
using DataLibrary.Business_Logic;
using DataLibrary.Data_Access;
using System.Data;

namespace TestLilyCord.Controllers
{
    public class PacientController : Controller
    {
        public ActionResult ViewPacient()
        {
            var data = PacientProcessor.LoadPacient();
            List<PacientModel> pacient = new List<PacientModel>();

            foreach (var row in data)
            {
                pacient.Add(new PacientModel
                {
                    id=row.id,
                    Email=row.Email,
                    Nume=row.Nume,
                    Prenume=row.Prenume,
                    CNP=row.CNP,
                    Adresa=row.Adresa,
                    Telefon=row.Telefon,
                    Varsta=row.Varsta,
                    Greutate=row.Greutate,
                    Diagnostic=row.Diagnostic
                });
            }

            return View(pacient);
        }

        public ActionResult ViewDiagnostic()
        {
            var data = DiagnosticProcessor.LoadDiagnostic();
            List<DiagnosticModel> diagnostic = new List<DiagnosticModel>();

            foreach (var row in data)
            {
                diagnostic.Add(new DiagnosticModel
                {
                    id = row.id,
                    Diagnostic = row.Diagnostic,
                    Investigatii_efectuate=row.Investigatii_efectuate,
                    Rezultate_investigatii=row.Rezultat_investigatii,
                    Tratament=row.Tratament,
                    Medicatie=row.Medicatie,
                    Email=row.Email
                });
            }

            return View(diagnostic);
        }
    }
}