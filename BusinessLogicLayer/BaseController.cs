using BusinessLogicLayer.Model;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public abstract class BaseController<T> where T : ViewModel
    {
        protected Repository repository = new Repository();

        public abstract List<T> GetAll();

    }
}
