using ASP.Net_CRUD.Data;
using ASP.Net_CRUD.Models;
using ASP.Net_CRUD.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_CRUD.Controllers
{
    //localhost:port/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDBContext dBContext;

        public EmployeesController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        //Get all Employee
        [HttpGet]
        public IActionResult GetAllEmployeees() {
            var allEmployees = dBContext.Employees.ToList();
            return Ok(allEmployees);
        }

        //Get Employee By ID
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetSingleEmployee(Guid id)
        {
            var employeeID = dBContext.Employees.Find(id);
            if(employeeID is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employeeID);
            }
        }

        //Add new Employee
        [HttpPost]
        public IActionResult AddEmployees(AddEmployeeDTO addEmployeeDTO)
        {
            var employeeEntity = new Employee() {
                Name = addEmployeeDTO.Name,
                Email = addEmployeeDTO.Email,
                Phone = addEmployeeDTO.Phone,
                Salary = addEmployeeDTO.Salary,
            };

            dBContext.Employees.Add(employeeEntity);
            dBContext.SaveChanges();

            return Ok(employeeEntity);
            
        }

        //Put or Edit Employee Data
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult updateEmployee(Guid id, UpdateEmployeeDTO updateEmployeeDTO)
        {
            var employeeId = dBContext.Employees.Find(id);
            if(employeeId is null)
            {
                return NotFound();
            }
            else
            {
                employeeId.Name = updateEmployeeDTO.Name;
                employeeId.Email = updateEmployeeDTO.Email;
                employeeId.Phone = updateEmployeeDTO.Phone;
                employeeId.Salary = updateEmployeeDTO.Salary;

                dBContext.SaveChanges();

                return Ok(employeeId);
            }

        }

        //Delete
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult deleteEmployee(Guid id)
        {
            var employeeID = dBContext.Employees.Find(id);
            if (employeeID is null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employeeID);
            }
        }
    }
}
