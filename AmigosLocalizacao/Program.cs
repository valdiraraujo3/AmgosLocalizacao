using AmigosLocalizacao.Classes.DAL;
using AmigosLocalizacao.Classes.Utils.Mensagens;
using System;

namespace AmigosLocalizacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declarações
            string codigoPesquisa = string.Empty;
            string top = string.Empty;
            string retorno = string.Empty;
            Mensagens mensagens;
            ListaAmigosDAO listaAmigos;

            try
            {
                //Instancias e Inicializações
                mensagens = new Mensagens();

                Console.WriteLine(mensagens.msg007());
                Console.WriteLine(mensagens.msg008());
                Console.WriteLine(mensagens.msg002());

                codigoPesquisa = Console.ReadLine();

                if (int.Parse(codigoPesquisa) > 0 && int.Parse(codigoPesquisa) <= 10)
                {
                    Console.WriteLine(mensagens.msg003());
                    top = Console.ReadLine();

                }

                if (int.Parse(codigoPesquisa) <= 10 && int.Parse(codigoPesquisa) > 0)
                {
                    if (string.IsNullOrEmpty(top))
                    {
                        top = "0";
                    }

                    listaAmigos = new ListaAmigosDAO();
                    Console.WriteLine(mensagens.msg008());
                    Console.WriteLine("{0}", mensagens.msg004(codigoPesquisa));
                    Console.WriteLine(mensagens.msg008());
                    Console.WriteLine(mensagens.msg005());

                    foreach (var item in listaAmigos.Pesquisar(int.Parse(codigoPesquisa), int.Parse(top)))
                    {
                        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", "(" + item.id + ")", item.nome_amigo, item.cidade, item.Distancia + " KM");
                    }
                    if (top == "0")
                    {
                        top = "3";
                    }
                    Console.WriteLine("");
                    Console.WriteLine(mensagens.msg008());
                    Console.WriteLine("{0}", mensagens.msg006(top));
                    Console.WriteLine(mensagens.msg008());
                }
                else
                    Console.WriteLine(mensagens.msg001(codigoPesquisa));

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