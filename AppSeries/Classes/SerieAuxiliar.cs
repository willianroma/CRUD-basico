using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Classes
{
    public static class SerieAuxiliar
    {

        static SerieRepositorio repositorio = Dados.repositorioSerie;
        public static void Principal()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default: Console.WriteLine("Opção invalida.");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VisualizarSerie()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            var lista = repositorio.Listar();

            foreach (var serie in lista)
            {
                if (serie.retornarId() == idSerie)
                {
                    Console.WriteLine(serie.ToString());
                }
            }

        }

        private static void ExcluirSerie()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(idSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizarSerie = new (id: indiceSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Atualizar(indiceSerie, atualizarSerie);
        }

        private static void InserirSerie()
        {
            Console.Clear();
            Console.WriteLine("Inserir nova Série.");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new(id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Inserir(novaSerie);
        }

        private static void ListarSeries()
        {
            Console.Clear();
            Console.WriteLine("Listar Serie.");

            var lista = repositorio.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                if (!serie.retornaExcluido())
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornarId(), serie.retornarTitulo());
                }
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir nova Serie");
            Console.WriteLine("3 - Atualizar Serie");
            Console.WriteLine("4 - Excluir Serie");
            Console.WriteLine("5 - Visualizar Serie");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
