using System.Collections.Generic;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Delete(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insert(Serie Entidade)
        {
            listaSerie.Add(Entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornoPorId(int id)
        {
            return listaSerie[id];
        }

        public void Update(int id, Serie Entidade)
        {
            listaSerie[id] = Entidade;
        }
    }
}