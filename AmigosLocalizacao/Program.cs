using AmigosLocalizacao.Classes.DAL;
using System;

namespace AmigosLocalizacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declarações
            string codigoPesquisa = string.Empty;
            string retorno = string.Empty;

            try
            {
                //Instancias e Inicializações
                if (DateTime.Now.Hour < 12)
                {
                    Console.WriteLine("Olá bom dia!");
                }
                else if(DateTime.Now.Hour < 18)
                {
                    Console.WriteLine("Olá boa tarde!");
                }
                else
                {
                    Console.WriteLine("Olá boa noite!");
                }

                Console.WriteLine("Entre com o código para pesquisa.");
                codigoPesquisa = Console.ReadLine();

                if (int.Parse(codigoPesquisa) <= 10 && int.Parse(codigoPesquisa) > 0)
                {
                    ListaAmigosDAO listaAmigos = new ListaAmigosDAO();

                    Console.WriteLine("{0}", "Código selecionado: " + "{" + codigoPesquisa + "}");
                    Console.WriteLine("| Código |    | Nome |        | Cidade |      | Distâcia |");

                    foreach (var item in listaAmigos.Pesquisar(int.Parse(codigoPesquisa)))
                    {
                        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "{" + item.id + "}", item.nome_amigo, item.cidade, item.Distancia + " KM");
                    }
                }
                else
                    Console.WriteLine("Código " + "{" + codigoPesquisa + "}" + " inválido, insira códigos de 1 a 10.");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
                Console.WriteLine("{0}", retorno);
            }
        }
    }
}