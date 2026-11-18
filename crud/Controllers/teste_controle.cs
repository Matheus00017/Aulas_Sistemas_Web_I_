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
        public IActionResult lista()
        {
            using var cone = new SqliteConnection(conexao);

            cone.Open();

            string slqcons = @" select * from usuario ";

            using var cmd = new SqliteCommand(slqcons, cone);

            using var teste = cmd.ExecuteReader();

            List<object> dados = new List<object>();

            while (teste.Read())

            {
                dados.Add(new
                {
                    id = teste["id"].ToString(),
                    usu = teste["usu"].ToString(),
                    senha = teste["senha"].ToString(),
                    nome = teste["nome"].ToString()
                });

            }

            return Json(dados);
        }



        [HttpGet]


        public string Logar(string usuario, string senha)
        {
            using var cone = new SqliteConnection(conexao);

            cone.Open();

            string sqlLogar = @"SELECT * FROM USUARIO WHERE
            USUARIOS = @pusu and senha = @Senha
            ";

            using var cmdLogin = new SqliteCommand(sqlLogar, cone);

            cmdLogin.Parameters.AddWithValue("@pusu", usuario);
            cmdLogin.Parameters.AddWithValue("@Senha", senha);

            using var confere = cmdLogin.ExecuteReader();

            if (confere.Read())
            {
                return confere["nome"].ToString()?? "";
            }

            return "ERRO";

        }

        [HttpGet]
        public string gravar(string usu, string senha, string nome)
        {
            using var cone = new SqliteConnection(conexao);
            cone.Open();
            string sqlinsere = @" INSERT OR IGNORE INTO usuario (usu, senha , nome) VALUES (@usu, @senha,@nome) ";
            using var cmd = new SqliteCommand(sqlinsere, cone);
            cmd.Parameters.AddWithValue("@usu", usu);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);
            int quat = cmd.ExecuteNonQuery();
            if (quat > 0)
            {
                return "gravado com sucesso !!!";
            }
            return "erro";
        }

        [HttpGet]
        public string atualizar(string id, string usu, string senha, string nome)
        {
            using var cone = new SqliteConnection(conexao);
            cone.Open();
            string sqlinsere = @" UPDATE usuario SET usu = @usu, senha = @senha, nome = @nome WHERE id = @id ";
            using var cmd = new SqliteCommand(sqlinsere, cone);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@usu", usu);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);
            int quat = cmd.ExecuteNonQuery();
            if (quat > 0)
            {
                return "atualizado com sucesso !!!";
            }
            return "erro";
        }

        [HttpGet]
        public string deletar(string id)
        {
            using var cone = new SqliteConnection(conexao);
            cone.Open();
            string sqlinsere = @" DELETE FROM usuario WHERE id = @id ";
            using var cmd = new SqliteCommand(sqlinsere, cone);
            cmd.Parameters.AddWithValue("@id", id);
            int quat = cmd.ExecuteNonQuery();
            if (quat > 0){
                return "apagado com sucesso !!!";
            }
            return "erro";
        }

        

    }
}