using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class MateriaDO : IDataObject
    {
        public MateriaDO() { }
        public MateriaDO(string descripcion, int id = 0)
        {
            ID = id;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }

        public string ListarValores()
        {
            return $"'{Descripcion}', '{ID}'";
        }

        public string GenerarValores()
        {
            return $"Descripcion = '{Descripcion}' WHERE IdAlumno = {ID}";
        }

        public string ListarColumnas()
        {
            return "Descripcion";
        }
    }
}
