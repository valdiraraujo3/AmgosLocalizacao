using System;

namespace AmigosLocalizacao.Classes.Utils.Mensagens
{
    #region Publico


    /// <summary>
    /// Classe responsavél por todas as mensagens a serem exibidas no sistema
    /// </summary>

    public class Mensagens
    {

        #region Métodos Publicos

        /// <summary>
        /// Método responsavél por retornar mensagem de erro código inválido.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public string msg001(string codigo)
        {
            string msg001 = "Código " + "(" + codigo + ")" + " inválido, insira códigos de (1 a 10).";

            return msg001;
        }

        /// <summary>
        /// Método responsavél por retornar mensagem de entrada do codigo de pesquisa.
        /// </summary>
        /// <returns></returns>
        public string msg002()
        {
            string msg002 = "Entre com um código entre (1 e 10) para pesquisa.";

            return msg002;
        }

        /// <summary>
        /// Método responsavél por retornar mensagem de solicitação de quantidade a ser retornada.
        /// </summary>
        /// <returns></returns>
        public string msg003()
        {
            string msg002 = "Quantidade para retorno. (Enter para top 3).";

            return msg002;
        }

        /// <summary>
        /// Método responsavél por retornar mensagem de qual foi o codigo foi selecioado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public string msg004(string codigo)
        {
            string msg004 = "Código selecionado: " + "(" + codigo + ")";

            return msg004;
        }

        /// <summary>
        /// Método responsavél por retornar o cabeçalho a ser exibido.
        /// </summary>
        /// <returns></returns>
        public string msg005()
        {
            string msg005 = "| Código |     | Nome |        | Cidade |      | Distâcia |";

            return msg005;
        }

        /// <summary>
        /// Método responsavél por retornar a mensagem de quantidade de registros retornados.
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public string msg006(string top)
        {
            string msg006 = "Foram retornados " + "(" + top + ")" + " registros.";

            return msg006;
        }

        /// <summary>
        /// Método responsavél por retornar a mensagem do topo, Bom dia, Boa tarde ou Boa noite.
        /// </summary>
        /// <returns></returns>
        public string msg007()
        {
            string msg007 = string.Empty;

            if (DateTime.Now.Hour < 12)
            {
                msg007 = "Olá, bom dia!";
            }
            else if (DateTime.Now.Hour < 18)
            {
                msg007 = "Olá, boa tarde!";
            }
            else
            {
                msg007 = "Olá, boa noite!";
            }

            return msg007;
        }

        /// <summary>
        /// Método responsavél por separar os itens.
        /// </summary>
        /// <returns></returns>
        public string msg008()
        {
            string msg008 = "-------------------------------------------------------------";

            return msg008;
        }

            #endregion

        }

    #endregion

}
