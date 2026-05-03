using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _productService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpGet("GetByCategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPost("Add")]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult DeleteById(int productId)
        {
            var result = _productService.Delete(productId);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }
    }
}

