using DataLibrary.Data_Access;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Business_Logic
{
    public static class LoginProcessor
    {
        public static int CreateLogin(string email, string parola)
        {
            LoginModel data = new LoginModel
            {
                Email = email,
                Parola = parola
            };
            string sql = @"insert into dbo.Login (email, parola) values (@Email, @Parola);";

            return SQLDataAceess.SaveData(sql, data);
        }

        public static List<LoginModel> LoadLogin()
        {
            string sql = @"select email from dbo.Login;";
            return SQLDataAceess.LoadData<LoginModel>(sql);
        }
    }
}
