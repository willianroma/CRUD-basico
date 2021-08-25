using AppSeries.Classes;
using System;

namespace AppSeries
{
    class Program
    {


        static void Main(string[] args)
        {
            Dados.Filmes();
            Dados.Series();
            string opcaoUsuario = FilmeSerie();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        SerieAuxiliar.Principal();
                        break;
                    case "2":
                        FilmeAuxiliar.Principal();
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = FilmeSerie();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
        }

        private static string FilmeSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao D.I.O Filmes e Séries!!");
            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine();
            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filme");
            Console.WriteLine("X - Fechar");
            Console.WriteLine();
            string opcao = Console.ReadLine();
            Console.WriteLine();
            return opcao;
        }

    }
}
