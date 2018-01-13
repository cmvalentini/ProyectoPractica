using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public interface IDataObject
    {
        string ListarValores();
        string GenerarValores();
        string ListarColumnas();
    }
}
