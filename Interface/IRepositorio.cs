using System.Collections.Generic;

namespace DIO.Series
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornoPorId(int id);
        void Insert(T Entidade);
        void Delete(int id);
        void Update(int id, T Entidade);
        int ProximoId();
    }
}