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
    public class RolRepository<T> : IRepository<Role> where T : class
    {

        public RolRepository() { }

        public void add(Role element)
        {
            using (var db = new DataConnection())
            {
                db.Insert(element);
            }
        }

        public void delete(Role element)
        {
            using (var db = new DataConnection())
            {
                db.Delete(element);
            }
        }

        public IEnumerable<Role> GetAll()
        {
            using (var db = new DataConnection())
            {
                return db.GetTable<Role>();
            }
        }

        public Role? GetById(Guid id)
        {
            using (var db = new DataConnection())
            {
                return db.GetTable<Role>().FirstOrDefault(x => x.IdRol == id);
            }
        }

        public void update(Role element)
        {
            using (var db = new DataConnection())
            {
                db.Update(element);
            }
        }
    }
}
