using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class AlumnoDO : IDataObject
    {
        public AlumnoDO() { }
        public AlumnoDO(string nombre, string apellido, int id = 0)
        {
            Nombre = nombre;
            Apellido = apellido;
            ID = id;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        
        public string ListarValores()
        {
            return $"'{Nombre}', '{Apellido}'";
        }

        public string GenerarValores()
        {
           return $"Nombre = '{Nombre}', Apellido = '{Apellido}' WHERE IdAlumno = {ID}";
        }

        public string ListarColumnas()
        {
            return "Nombre, Apellido";
        }
    }
}
