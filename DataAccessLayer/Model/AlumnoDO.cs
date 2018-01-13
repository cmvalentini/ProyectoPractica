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
    }
}
