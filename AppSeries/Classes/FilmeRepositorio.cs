using AppSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Classes
{
    class FilmeRepositorio : IRepositorio<Filme>
    {
        private readonly List<Filme> listarFilme = new();

        public void Atualizar(int id, Filme filme)
        {
            listarFilme[id] = filme;
        }

        public void Excluir(int id)
        {
            listarFilme[id].Excluir();
        }

        public void Inserir(Filme filme)
        {
            listarFilme.Add(filme);
        }

        public List<Filme> Listar()
        {
            return listarFilme;
        }

        public int ProximoId()
        {
            return listarFilme.Count;
        }

        public Filme RetornarPorId(int id)
        {
            return listarFilme[id];
        }

    }
}
