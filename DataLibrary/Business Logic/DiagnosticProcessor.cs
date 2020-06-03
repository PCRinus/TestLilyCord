using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Business_Logic
{
    public static class DiagnosticProcessor
    {
        public static int CreateDiagnostic(int id, string diagnostic, string investigatii_efectuate, string rezultat_investigatii, string tratament, string medicatie, string email)
        {
            DiagnosticModel data = new DiagnosticModel
            {
                id = id,
                Diagnostic = diagnostic,
                Investigatii_efectuate=investigatii_efectuate,
                Rezultat_investigatii=rezultat_investigatii,
                Tratament=tratament,
                Medicatie=medicatie,
                Email=email
            };
            string sql = @"insert into dbo.Diagnostic (id, diagnostic, investigatii_efectuate, rezultat_investigati, tratament, medicatie, email) values (@id, @Diagnostic, @Investigatii_efectuate, @Rezultat_investigatii, @Tratament, @Medicatie, @Email);";

            return SQLDataAceess.SaveData(sql, data);
        }

        public static List<DiagnosticModel> LoadDiagnostic()
        {
            string sql = @"select dbo.Diagnostic.id, dbo.Diagnostic.diagnostic, dbo.Diagnostic.investigatii_efectuate, dbo.Diagnostic.rezultat_investigatii, dbo.Diagnostic.tratament, dbo.Diagnostic.medicatie, dbo.Login.email from dbo.Diagnostic inner join dbo.Login on dbo.Diagnostic.email = dbo.Login.email;";
            return SQLDataAceess.LoadData<DiagnosticModel>(sql);
        }
    }
}
