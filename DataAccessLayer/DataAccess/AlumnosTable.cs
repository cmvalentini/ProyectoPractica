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
        public override string Tabla { get; } = "Alumnos";
        public override string ColumnaKey { get; } = "IdAlumno";
        protected override AlumnoDO Map(IDataRecord record)
        {
            var alum = new AlumnoDO();
            alum.ID = (int)record[ColumnaKey];
            alum.Nombre = (string)record["Nombre"];
            alum.Apellido = (string)record["Apellido"];
            return alum;
        }
    }
}
