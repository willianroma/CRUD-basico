using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Classes
{
    class Dados
    {
        public static FilmeRepositorio repositorioFilme = new();
        public static SerieRepositorio repositorioSerie = new();
        //Filmes cadastrados quando inicia
        public static void Filmes()
        {
            
            var lista = repositorioFilme.Listar();
            Filme filme = new(id: repositorioFilme.ProximoId(), genero: Genero.Acao, titulo: "FilmetesteAÇão", descricao: "DescriTeste", ano: 2011);
            repositorioFilme.Inserir(filme);
            Filme filme2 = new(id: repositorioFilme.ProximoId(), genero: Genero.Aventura, titulo: "FilmetesteAventur", descricao: "DescriTeste", ano: 2001);
            repositorioFilme.Inserir(filme2);
            Filme filme3 = new(id: repositorioFilme.ProximoId(), genero: Genero.Acao, titulo: "Filmeteste2AÇão2", descricao: "DescriTeste", ano: 2012);
            repositorioFilme.Inserir(filme3);
            Filme filme4 = new (id: repositorioFilme.ProximoId(), genero: Genero.Romance, titulo: "FilmetesteRomanc", descricao: "DescriTeste", ano: 2020);
            repositorioFilme.Inserir(filme4);
        }
        //Séries cadastradas quando inicia
        public static void Series()
        {
            Serie serie = new (id: repositorioSerie.ProximoId(), genero: Genero.Comedia, titulo: "SerietesteComedia", descricao: "DescriTeste", ano: 2011);
            repositorioSerie.Inserir(serie);
            Serie serie2 = new (id: repositorioSerie.ProximoId(), genero: Genero.Aventura, titulo: "SerietesteAventur", descricao: "DescriTeste", ano: 2001);
            repositorioSerie.Inserir(serie2);
            Serie seri3 = new (id: repositorioSerie.ProximoId(), genero: Genero.Drama, titulo: "Serieteste2AÇão2", descricao: "DescriTeste", ano: 2008);
            repositorioSerie.Inserir(seri3);
            Serie serie4 = new (id: repositorioSerie.ProximoId(), genero: Genero.Romance, titulo: "SerietesteRomanc", descricao: "DescriTeste", ano: 2020);
            repositorioSerie.Inserir(serie4);
        }


    }
}
