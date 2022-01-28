using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.DataAccess;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository _repository;

        /*
        * For simplicity I am using the Data entity
        * but I could also use API specific model to be
        * inclued in API response
        */

        public EmployeeService(IRepository repository)
        {
            // Allows me to inject any repository in memory
            // or any concrete implementation
            _repository = repository;
        }

        public IEnumerable<Employee> GetAll()
        {

            return _repository.GetAll();
        }


        public IList<Employee> ListAll()
        {
            return _repository.ListAll();
        }

        public IEnumerable<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            return _repository.GetAllByDepartmentId(departmentId);
        }


    }
}
