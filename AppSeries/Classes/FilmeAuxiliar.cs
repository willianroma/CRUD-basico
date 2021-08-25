using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Classes
{
    class FilmeAuxiliar
    {
        static readonly FilmeRepositorio repositorio = Dados.repositorioFilme;
        public static void Principal()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilme();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizarFilme();
                        break;
                    case "4":
                        ExcluirFilme();
                        break;
                    case "5":
                        VisualizarFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default: throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VisualizarFilme()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            var lista = repositorio.Listar();

            foreach (var filme in lista)
            {
                if (filme.retornarId() == idFilme)
                {
                    Console.WriteLine(filme.ToString());
                }
            }

        }

        private static void ExcluirFilme()
        {
            Console.WriteLine("Digite o ID da filme: ");
            int idFilme = int.Parse(Console.ReadLine());

            repositorio.Excluir(idFilme);
        }

        private static void AtualizarFilme()
        {
            Console.Clear();
            Console.WriteLine("Digite o ID da filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Clear();
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o título da filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o ano de início da filme: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a descrição da filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizarFilme = new Filme(id: indiceFilme,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Atualizar(indiceFilme, atualizarFilme);
        }

        private static void InserirFilme()
        {
            Console.Clear();
            Console.WriteLine("Inserir novo Filme:");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite o título da filme: ");
            string entradaTitulo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite o ano de início da filme: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a descrição da filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);

            repositorio.Inserir(novoFilme);
        }

        private static void ListarFilme()
        {
            Console.Clear();
            Console.WriteLine("Listar Filme:");

            var lista = repositorio.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                if (!filme.retornaExcluido())
                {
                    Console.WriteLine("#ID {0}: - {1}", filme.retornarId(), filme.retornarTitulo());
                }
            }
        }
        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listar Filme");
            Console.WriteLine("2 - Inserir novo Filme");
            Console.WriteLine("3 - Atualizar Filme");
            Console.WriteLine("4 - Excluir Filme");
            Console.WriteLine("5 - Visualizar Filme");
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

