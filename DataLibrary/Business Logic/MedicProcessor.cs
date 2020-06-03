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
        public static int CreateMedic(int medicID, string email, string nume, string prenume)
        {
            MedicModel data = new MedicModel
            {
                MedicId = medicID,
                Email = email,
                Nume = nume,
                Prenume = prenume
            };

            string sql = @"insert into dbo.Medici (medicID, email, nume, prenume) values (@MedicId, @Email, @Nume, @Prenume);"; 

            return SQLDataAceess.SaveData(sql, data);
        }
        public static List<MedicModel> LoadMedic()
        {
            string sql = @"select Id, MedicId, Nume, Prenume, Email from dbo.Medici;";
            return SQLDataAceess.LoadData<MedicModel>(sql);
        }
    }
}
