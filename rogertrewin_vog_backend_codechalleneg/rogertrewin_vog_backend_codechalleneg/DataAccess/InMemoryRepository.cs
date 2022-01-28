using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.DataAccess
{
    public class InMemoryRepository : IRepository
    {
        private List<Employee> EmployeesDb { get; set; } = new List<Employee>();
        public InMemoryRepository()
        {
            EmployeesDb.Add(new Employee { EmployeeId = 1, DeparmentId = 1, FirstName = "Employee Name1", LastName = "Employee LastName1", JobTitle = "Title1", MailingAddress = "Address1" });
            EmployeesDb.Add(new Employee { EmployeeId = 2, DeparmentId = 2, FirstName = "Employee Name2", LastName = "Employee LastName2", JobTitle = "Title2", MailingAddress = "Address2" });
            EmployeesDb.Add(new Employee { EmployeeId = 3, DeparmentId = 2, FirstName = "Employee Name3", LastName = "Employee LastName3", JobTitle = "Title3", MailingAddress = "Address3" });

        }

        public IEnumerable<Employee> GetAll()
        {
            return EmployeesDb.ToList();
        }

        public IList<Employee> ListAll()
        {
            return EmployeesDb;
        }

        public IEnumerable<Employee> GetAllByDepartmentId(int departmentId)
        {
            return EmployeesDb.Where(e => e.DeparmentId == departmentId);
        }
    }
}
