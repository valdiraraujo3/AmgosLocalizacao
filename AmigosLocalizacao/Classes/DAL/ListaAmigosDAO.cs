using AmigosLocalizacao.Classes.Conn;
using AmigosLocalizacao.Classes.Model;
using AmigosLocalizacao.Classes.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AmigosLocalizacao.Classes.DAL
{
    /// <summary>
    /// Classe responsavél por disparar a execução contra o banco dados
    /// </summary>
    public class ListaAmigosDAO
    {
        #region Métodos Publicos

        public List<AmigosLocalizacaoModel> Pesquisar(int codigoPesquisa)
        {
            //Declarações
            string id = string.Empty;
            string nomeAmigo = string.Empty;
            string cidade = string.Empty;
            string point = string.Empty;
            string distancia = string.Empty;
                       
            List<AmigosLocalizacaoModel> retorno = new List<AmigosLocalizacaoModel>();

            var linhas = new List<AmigosLocalizacaoModel>();
            var ConStr = GetConn();

            using (var conn = new SqlConnection(ConStr))
            {
                try
                {
                    SqlCommand command = new SqlCommand("[dbo].[sp_sel_amigos]", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int)).Value = codigoPesquisa;
                    conn.Open();
                    command.ExecuteNonQuery();

                    var returnValue = command.ExecuteReader();

                    while (returnValue.Read())
                    {
                        AmigosLocalizacaoModel linha = new AmigosLocalizacaoModel();

                        //Mapeamento das colunas retornadas pela procedure
                        id = returnValue["Id"].ToString();
                        cidade = returnValue["Cidade"].ToString();
                        point = returnValue["Point"].ToString();
                        nomeAmigo = returnValue["Nome_Amigo"].ToString();
                        distancia = returnValue["Distancia"].ToString();

                        linha.id = int.Parse(id);
                        linha.nome_amigo = nomeAmigo;
                        linha.cidade = cidade;
                        linha.Point = point;
                        linha.Distancia = Util.ConvertMetrosParaKms(double.Parse(distancia));

                        linhas.Add(linha);
                    }
                }
                catch (System.Exception ex)
                {

                    throw;
                }
            }

            return retorno = linhas;
        }

        #endregion

        #region Métodos Priados

        //Método resposavel pela string de conexão.  
        private string GetConn()
        {
            string connectionString = string.Empty;
            Conexao strCon = new Conexao();
            return connectionString = strCon.Connection();
        }

        #endregion
    }
}