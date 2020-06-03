using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Business_Logic
{
    public static class PacientProcessor
    {
        public static int CreatePacient(/*int id,*/ string email, string nume, string prenume, int cnp, string adresa, int telefon, int varsta, int inaltime, int greutate)
        {
            PacientModel data = new PacientModel
            {
                //Id = id,
                Email = email,
                Nume = nume,
                Prenume = prenume,
                CNP=cnp,
                Adresa=adresa,
                Telefon = telefon,
                Varsta = varsta,
                Inaltime=inaltime,
                Greutate=greutate
            };

            //string sql = @"insert into dbo.Medici (id, medicid, nume, prenume, email, grad_profesional,telefon,specializare) values (@Id, @MedicId, @Nume, @Prenume, @Email, @Grad_profesional, @Telefon, @Specializare);"; 

            string sql_id = @"";

            string sql = @"insert into dbo.Pacient (email, nume, prenume, cnp, adresa, telefon, varsta, inaltime, greutate) values (@Email, @Nume, @Prenume, @CNP, @Adresa, @Telefon, @Varsta, @Inaltime, @Greutate);";

            return SQLDataAceess.SaveData(sql, data);
        }

        public static List<PacientModel> LoadPacient()
        {
            string sql = @"select email, nume, prenume, cnp, adresa, telefon, varsta, inaltime, greutate, diagnostic from dbo.Pacient;";
            return SQLDataAceess.LoadData<PacientModel>(sql);
        }

        public static List<PacientModel> LoadSpecificPacient()
        {
            string sql = @"select dbo.Login.email, dbo.Pacient.nume, dbo.Pacient.prenume, dbo.Pacient.cnp, dbo.Pacient.adresa, dbo.Pacient.telefon, dbo.Pacient.varsta, dbo.Pacient.inaltime, dbo.Pacient.greutate from dbo.Pacient inner join dbo.Login on dbo.Pacient.email = dbo.Login.email;";
            return SQLDataAceess.LoadData<PacientModel>(sql);
        }
    }
}
