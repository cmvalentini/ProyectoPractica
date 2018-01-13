using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class MateriasTable : IDataTable<MateriaDO>
    {
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<MateriaDO> GetAll()
        {
            throw new NotImplementedException();
        }

        public override IDataObject GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Insert(MateriaDO objeto)
        {
            throw new NotImplementedException();
        }

        public override bool Update(MateriaDO objeto)
        {
            throw new NotImplementedException();
        }
    }
}
