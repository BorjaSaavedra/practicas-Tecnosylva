using DataModels;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gestorModel.Repository
{
    public class CapaRepository<T> : IRepository<Capa>
    {   

        public CapaRepository() { }

        public void add(Capa element)
        {
            using (var db = new DataConnection())
            {
                db.Insert(element);
            }
        }

        public void delete(Capa element)
        {
            using (var db = new DataConnection())
            {
                db.Delete(element);
            }
        }

        public IEnumerable<Capa> GetAll()
        {
            using (var db = new DataConnection())
            {
                //Comprobar si funciona esto
                return db.GetTable<Capa>();
            }
        }

        public Capa? GetById(Guid id)
        {
            using (var db = new DataConnection())
            {
                //Esto tampoco se si funcionara
                return db.GetTable<Capa>().FirstOrDefault(x => x.IdCapa == id);

            }
        }

        public void update(Capa element)
        {
            using (var db = new DataConnection())
            {
                db.Update(element);
            }
        }
    }
}
