using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _orderService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }
        [HttpPost("Add")]
        public IActionResult Post(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
