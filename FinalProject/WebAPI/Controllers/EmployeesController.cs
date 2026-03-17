using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _employeeService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpGet("GetById,{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _employeeService.GetById(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPost("Add")]
        public IActionResult Post(Employee employee)
        {
            var result = _employeeService.Add(employee);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
