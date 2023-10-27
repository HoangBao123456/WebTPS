using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer;
using DataModel;
using BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace WebHoaQua.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class sanphamController : ControllerBase
    {
        private IsanphamBusiness _categorysBusiness;
        public sanphamController(IsanphamBusiness iloaihangBusiness) {
            _categorysBusiness = iloaihangBusiness;
        }

        [AllowAnonymous]
        [HttpGet("getlist")]
        public List<Products> Get() {
            return _categorysBusiness.GetList();
        }
        [AllowAnonymous]
        [HttpPost("themsanpham")]
        public IActionResult Insert(Products products)
        {
            var result = _categorysBusiness.Insert(products);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("update")]
        public IActionResult Update(Products products)
        {
            var result = _categorysBusiness.Update(products);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("xoa")]
        public IActionResult Delete(string id)
        {
            var result = _categorysBusiness.Delete(id);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpGet("getid/{id}")]
        public Products GetById(string id)
        {
            return _categorysBusiness.GetById(id);
        }

    }
}
