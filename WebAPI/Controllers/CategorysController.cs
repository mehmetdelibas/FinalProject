using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        ICategoryServices _categoryService;

        public CategorysController(ICategoryServices categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpGet("GetById,{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPost("Add")]
        public IActionResult Post(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
