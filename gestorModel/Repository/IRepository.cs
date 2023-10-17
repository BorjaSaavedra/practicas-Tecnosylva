using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorModel.Repository
{
    public interface IRepository<T>
    {
        //Operaciones a realizar en la base de datos
        T? GetById(Guid id);
        IEnumerable<T> GetAll();
        void add(T element);
        void update(T element);
        void delete(T element);

    }
}
