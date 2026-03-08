using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
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
