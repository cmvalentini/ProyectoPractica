using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class MateriasTable : IDataTable<MateriaDO>
    {
        //Completar como en AlumnosTable
        public override string ColumnaKey
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override List<string> Columnas
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Tabla
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override MateriaDO Map(IDataRecord record)
        {
            throw new NotImplementedException();
        }
    }
}
