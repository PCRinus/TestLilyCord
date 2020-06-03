using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Business_Logic
{
    public static class MedicProcessor
    {
        public static int CreateMedic(/*int id,*/ int medicId, string nume, string prenume, string email, string grad_profesional, int telefon, string specilaizare)
        {
            MedicModel data = new MedicModel
            {
                //Id = id,
                MedicId = medicId,
                Nume = nume,
                Prenume = prenume,
                Email=email,
                Grad_profesional=grad_profesional,
                Telefon=telefon,
                Specializare=specilaizare
            };

            //string sql = @"insert into dbo.Medici (id, medicid, nume, prenume, email, grad_profesional,telefon,specializare) values (@Id, @MedicId, @Nume, @Prenume, @Email, @Grad_profesional, @Telefon, @Specializare);"; 

            string sql = @"insert into dbo.Medici (medicid, nume, prenume, email, grad_profesional,telefon,specializare) values (@MedicId, @Nume, @Prenume, @Email, @Grad_profesional, @Telefon, @Specializare);";

            return SQLDataAceess.SaveData(sql, data);
        }

        public static List<MedicModel> LoadMedic()
        {
            string sql = @"select MedicId, Nume, Prenume, Email, Grad_profesional, Telefon, Specializare from dbo.Medici;";
            return SQLDataAceess.LoadData<MedicModel>(sql);
        }
    }
}
