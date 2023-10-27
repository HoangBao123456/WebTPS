using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebHoaQua.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class taikhoanController : ControllerBase
    {
        private ITaikhoanBusiness _userBusiness;

        public taikhoanController(ITaikhoanBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [AllowAnonymous]
        [HttpPost("insert")]
        public IActionResult insert(Taikhoan taikhoan)
        {
            var result = _userBusiness.insert(taikhoan);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("update")]
        public IActionResult update(Taikhoan taikhoan)
        {
            var result = _userBusiness.update(taikhoan);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost("delete")]
        public IActionResult delete(string id)
        {
            var result = _userBusiness.delete(id);
            return Ok(result);
        }
        //[AllowAnonymous]
        //[HttpPost("login")]
        //public IActionResult Login([FromBody] AuthenticateModel model)
        //{
        //    var user = _userBusiness.Login(model.tentaikhoan, model.matkhau);
        //    if (user == null)
        //        return Ok(new
        //        {
        //            status = false,
        //            message = "Tài khoản hoặc mật khẩu không chính xác !"
        //        });

        //    return Ok(new {
        //        status = true,
        //        username = user.tentaikhoan,
        //        token = user.token 
        //    });
        //}

        //[AllowAnonymous]
        //[HttpPost("register")]
        //public IActionResult Register([FromBody] RegisterModel model)
        //{
        //    bool register = _userBusiness.Register(model.tentaikhoan, model.matkhau);
        //    if(!register)
        //    {
        //        return Ok(new
        //        {
        //            status = false,
        //            message = "Đăng kí tài khoản không thành công !"
        //        });
        //    }

        //    return Ok(new
        //    {
        //        status = true,
        //        message = "Đăng kí tài khoản thành công !",
        //        username = model.tentaikhoan,
        //        password = model.matkhau
        //    });
        //}

        //[HttpPost("update")]
        //public IActionResult Update([FromBody] UpdateModel model)
        //{
        //    bool update = _userBusiness.Update(model.hovaten, model.diachi, model.sdt, User.Identity.Name);
        //    if (update)
        //    {
        //        return Ok(new
        //        {
        //            status = true,
        //            message = "Cập nhật thông tin thành công!"
        //        });
        //    }
        //    else
        //    {
        //        return Ok(new
        //        {
        //            status = false,
        //            message = "Cập nhật thông tin thất bại!"
        //        });
        //    }
        //}

        //[HttpPost("getinfo")]
        //public IActionResult GetInfo()
        //{
        //    var results = _userBusiness.GetInfo(User.Identity.Name) ;
        //    return Ok(results);
        //}

        //[HttpPost("checkaccount")]
        //public IActionResult CheckAccounts()
        //{
        //    return Ok(new
        //    {
        //        status = true
        //    });
        //}
    }
}
