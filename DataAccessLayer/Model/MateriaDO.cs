using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class MateriaDO : IDataObject
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public string ListarValores()
        {
            throw new NotImplementedException();
        }

        public string GenerarValores()
        {
            throw new NotImplementedException();
        }

        public string ListarColumnas()
        {
            throw new NotImplementedException();
        }
    }
}
