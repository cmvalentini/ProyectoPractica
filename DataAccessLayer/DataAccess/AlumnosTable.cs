using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using System.Data.SqlClient;

namespace DataAccessLayer.DataAccess
{
    public class AlumnosTable : IDataTable<AlumnoDO>
    {
        public override bool Delete(int id)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"DELETE FROM Alumnos WHERE IdAlumno = {id}";
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

        public override List<AlumnoDO> GetAll()
        {
            var lista = new List<AlumnoDO>();
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM Alumnos";
            con.Open();
            IDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lista.Add(new AlumnoDO((string)reader["Nombre"], (string)reader["Apellido"], (int)reader["IdAlumno"]));
            }
            con.Close();
            return lista;
        }

        public override IDataObject GetById(int id)
        {
            AlumnoDO alum = new AlumnoDO();
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM Alumnos WHERE IdAlumno = {id}";
            con.Open();
            IDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                alum.ID = (int)reader["IdAlumno"];
                alum.Nombre = (string)reader["Nombre"];
                alum.Apellido = (string)reader["Apellido"];
                con.Close();
                return alum;
            }
            else
            {
                con.Close();
                throw new Exception("Alumno inexistente");
            }

        }

        public override bool Insert(AlumnoDO objeto)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"INSERT INTO Alumnos(Nombre, Apellido) VALUES('{objeto.Nombre}', '{objeto.Apellido}'); SELECT CAST(scope_identity() AS int)";
            con.Open();
            int newId = (int)command.ExecuteScalar();
            con.Close();
            if(newId == -1)
            {
                return false;
            }
            else
            {
                objeto.ID = newId;
                return true;
            }
        }

        public override bool Update(AlumnoDO objeto)
        {
            IDbConnection con = conexion.GetConnection();
            IDbCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"UPDATE Alumnos SET Nombre = '{objeto.Nombre}', Apellido = '{objeto.Apellido}' WHERE IdAlumno = {objeto.ID}";
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
    }
}
