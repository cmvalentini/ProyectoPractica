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
        public abstract string Tabla { get; }
        public abstract string ColumnaKey { get; }


        protected Connection.Connection conexion = new Connection.Connection();
        public List<T> GetAll()
        {
            var lista = new List<T>();
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM {Tabla}";
            con.Open();
            IDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(Map(reader));
            }
            con.Close();
            return lista;
        }
        public T GetById(int id)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM {Tabla} WHERE {ColumnaKey} = {id}";
            con.Open();
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                T obj = Map(reader);
                con.Close();
                return obj;
            }
            else
            {
                con.Close();
                throw new Exception("Alumno inexistente");
            }
        }

       public bool Insert(T objeto)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"INSERT INTO {Tabla}({objeto.ListarColumnas()}) VALUES({objeto.ListarValores()}); SELECT CAST(scope_identity() AS int)";
            con.Open();
            int newId = (int)command.ExecuteScalar();
            con.Close();
            if (newId == -1)
            {
                return false;
            }
            else
            {                
                return true;
            }
        }
        
        public bool Delete(int id)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"DELETE FROM {Tabla} WHERE {ColumnaKey} = {id}";
            con.Open();
            if (command.ExecuteNonQuery() == 0)
            {
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }
        }
        public bool Update(T objeto)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"UPDATE {Tabla} SET {objeto.GenerarValores()}";
            con.Open();
            int newId = command.ExecuteNonQuery();
            con.Close();
            if (newId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        abstract protected T Map(IDataRecord record);       
            

    }
}
