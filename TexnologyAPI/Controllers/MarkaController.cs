using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TexnologyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkaController : ControllerBase
    {
        private readonly IMarka _marka;

        public MarkaController(IMarka marka)
        {
            _marka = marka;
        }
        [HttpGet]
        public IActionResult GetMarka()
        {
            var values = _marka.GetAll();
            return Ok(values);
        }
        [HttpGet("id")]
        public IActionResult GetIdMarka(int id)
        {
            var values = _marka.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult InsertMarka(MarkaDTO m)
        {
            var answer = "Succesfully Added";
            _marka.Insert(m);
            return Ok(answer);
        }

        [HttpPut]
        public IActionResult UpdateMarka(MarkaDTO m,int id)
        {
            var answer = "Succesfully Updated";
            var values=_marka.GetById(id);
            _marka.Update(m);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteMarka(int id)
        {
            var answer = "Deleted";
            _marka.Delete(id);
            return Ok(answer);
        }
    }
}
