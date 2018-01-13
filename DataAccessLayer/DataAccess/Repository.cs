using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class Repository
    {
        private AlumnosTable alumnos = new AlumnosTable();
        public AlumnosTable Alumnos
        {
            get { return alumnos = new AlumnosTable(); }
        }
        private MateriasTable materias = new MateriasTable();

        public MateriasTable Materias
        {
            get { return materias = new MateriasTable(); }
        }
    }
}
