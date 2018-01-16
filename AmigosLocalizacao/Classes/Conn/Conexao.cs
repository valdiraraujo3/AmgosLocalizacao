using System.Configuration;

namespace AmigosLocalizacao.Classes.Conn
{
    /// <summary>
    /// Classe responsavél pelos dados da conexão com o banco de dados.
    /// </summary>
    public class Conexao
    {
        public string Connection()
        {
            string connectionString = string.Empty;
            return connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }


    }
}
