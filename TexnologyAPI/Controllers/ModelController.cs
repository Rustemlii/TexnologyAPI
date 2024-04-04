using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TexnologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModel _model;

        public ModelController(IModel model)
        {
            _model = model;
        }

        [HttpGet]
        public IActionResult GetModel()
        {
            var values=_model.GetAll();
            return Ok(values);
        }

        [HttpGet("id")]
        public IActionResult GetIdModel(int id)
        {
            var values=_model.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult InsertModel(ModelDTO model)
        {
            var answer = "Succesfully Added";
            _model.Insert(model);
            return Ok(answer);
        }

        [HttpPut]
        public IActionResult UpdateModel(ModelDTO model)
        {
            var answer = "Succesfully Updated";
            _model.Update(model);
            return Ok(answer);
        }
        [HttpDelete]
        public IActionResult DeleteModel(int id)
        {
            var answer = "Deleted";
            _model.Delete(id);
            return Ok(answer);
        }
    }
}
