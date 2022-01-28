using System.Collections.Generic;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IEnumerable<Employee> GetEmployeesByDepartmentId(int departmentId);
    }
}