using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace crud.Controllers
{
    public class Home : Controller
    {

         string conexao = @"Data Source = teste.db";

        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult crud()
        {
            return View();
        }

        [HttpGet]


        public string Login (string usuario, string senha)
        {
            using var cone = new SqliteConnection (conexao);

            cone.Open();

            string sqlLogin = @"SELECT * FROM USUARIO WHERE
            USUARIOS = @pusu and senha = @Senha
            ";

            using var cmdLogin = new SqliteCommand( sqlLogin, cone );

            cmdLogin.Parameters.AddWithValue("@pusu", usuario);
            cmdLogin.Parameters.AddWithValue("@Senha", senha);

            using var confere = cmdLogin.ExecuteReader();

            if (confere.Read())
            {
                return confere["nome"].ToString();
            }

            return "ERRO";

        }





    }
}