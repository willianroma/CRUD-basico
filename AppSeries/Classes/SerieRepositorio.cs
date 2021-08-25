using AppSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar(int id, Serie serie)
        {
            listaSerie[id] = serie;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Inserir(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
