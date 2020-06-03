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
        public static List<PacientModel> LoadPacient()
        {
            string sql = @"select email, nume, prenume, cnp, adresa, telefon, varsta, inaltime, greutate, diagnostic from dbo.Pacient;";
            return SQLDataAceess.LoadData<PacientModel>(sql);
        }
    }
}
