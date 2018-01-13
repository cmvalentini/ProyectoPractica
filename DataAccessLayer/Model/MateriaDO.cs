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
    }
}
