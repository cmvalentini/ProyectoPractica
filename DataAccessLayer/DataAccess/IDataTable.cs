using DataAccessLayer.Model;
using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public abstract class IDataTable<T> where T : IDataObject
    {
        protected Connection.Connection conexion = new Connection.Connection();
        abstract public List<T> GetAll();
        abstract public IDataObject GetById(int id);
        abstract public bool Insert(T objeto);
        abstract public bool Delete(int id);
        abstract public bool Update(T objeto);
    }
}
