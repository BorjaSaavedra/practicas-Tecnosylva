using DataModels;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gestorModel.Repository
{
    public class UserRepository<T> : IRepository<Usuario> 
    {
        //Clase principal de base de datos que se usa para realizar las operaciones CRUD

        public UserRepository ()
        {
        }

        public void add(Usuario element)
        {
            using (var db = new DataConnection())
            {
                db.Insert(element);
            }
        }

        public void delete(Usuario element)
        {
            using (var db = new DataConnection())
            {
                db.Delete(element);
                
            }
        }

        public Usuario? GetById(Guid id)
        {

            using (var db = new DataConnection())
            {
                //Esto tampoco se si funcionara
                return db.GetTable<Usuario>().FirstOrDefault(x => x.IdUsuario == id);
               
            }
            

        }

        public IEnumerable<Usuario> GetAll()
        {
            using (var db = new DataConnection())
            {
                //Este no se si funcionara
                return db.GetTable<Usuario>();

            }

        }

        public void update(Usuario element)
        {
            using (var db = new DataConnection())
            {
                db.Update(element);
            }
        }
    }
}
