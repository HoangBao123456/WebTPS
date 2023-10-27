using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataModel;
using BusinessLogicLayer.Interfaces;

namespace WebHoaQua.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PhanloaiController : ControllerBase
    {
        private IPhanloaiBusiness _phanloaiBusiness;
        public PhanloaiController(IPhanloaiBusiness phanloaiBusiness)
        {
            _phanloaiBusiness = phanloaiBusiness;
        }

        [AllowAnonymous]
        [HttpGet("getlist")]
        public List<Categorys> GetList()
        {
            return _phanloaiBusiness.GetList();
        }
        [AllowAnonymous]
        [HttpPost("insert")]
        public IActionResult Insert(Categorys categorys)
        {
            var result = _phanloaiBusiness.Insert(categorys);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("update")]
        public IActionResult Update(Categorys categorys)
        {
            var result =_phanloaiBusiness.Update(categorys);
            return Ok(result);  
        }
        [AllowAnonymous]
        [HttpPost("xoa")]
        public IActionResult Delete(string id)
        {
            var result = _phanloaiBusiness.Delete(id);
            return Ok(result);
        }
    }
}
