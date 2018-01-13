using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Model
{
    public class AlumnoViewModel : ViewModel
    {
        public AlumnoViewModel(int id, string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            ID = id;
        }
        public AlumnoViewModel(AlumnoDO alu)
        {
            ID = alu.ID;
            Nombre = alu.Nombre;
            Apellido = alu.Apellido;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
