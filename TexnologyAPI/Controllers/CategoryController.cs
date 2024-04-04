using Business.Abstract;
using DataAccess.Entity;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TexnologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet]
        public IActionResult GetCategory()
        {
            var values = _category.GetAll();
            return Ok(values);
        }

        [HttpGet("id")]
        public IActionResult GetCategoryId(int id)
        {
            var values = _category.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult InsertCategory(CategoryDTO c)
        {
            var answer = "Succesfully Added";
            _category.Insert(c);
            return Ok(answer);
        }
        [HttpPut]
        public IActionResult UpdateCategory(CategoryDTO c, int id)
        {
            var answer = "Succesfully Updated";
            var values = _category.GetById(id);
            _category.Update(c);
            return Ok(values);
           
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var answer = "Deleted";
            _category.Delete(id);
            return Ok(answer);
        }
    }
}
