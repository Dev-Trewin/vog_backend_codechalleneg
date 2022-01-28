using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _service.GetAll();
            return Ok(employees);
        }

        [Route("department/{departmentId:int}")]
        [HttpGet]
        public IActionResult GetEmployeesByDepartmentId(int departmentId)
        {
            var employees = _service.GetEmployeesByDepartmentId(departmentId);
            return Ok(employees);
        }


    }

}
