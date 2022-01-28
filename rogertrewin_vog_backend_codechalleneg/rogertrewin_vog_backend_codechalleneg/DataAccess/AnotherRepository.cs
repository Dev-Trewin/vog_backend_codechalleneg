using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.DataAccess
{
    public class AnotherRepository : IRepository
    {
        private readonly string _connString;

        public AnotherRepository(string connString)
        {
            this._connString = connString;
        }
        //Here I could implement EF to get the data
        //from SQL or whatever database we are using
        public IEnumerable<Employee> GetAll()
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllByDepartmentId(int departmentId)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
