using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;

namespace BusinessLogicLayer
{
    public class TaikhoanBusiness : ITaikhoanBusiness
    {
        private ITaikhoanRepository _res;
        public TaikhoanBusiness(ITaikhoanRepository res)
        {
            _res = res;
        }
        private string secret;

        public TaikhoanBusiness(DataAccessLayer.Interfaces.ITaikhoanRepository res, IConfiguration configuration)
        {
            _res = res;
            secret = configuration["AppSettings:Secret"];
        }

        public bool insert(Taikhoan taikhoan)
        {
            return _res.insert(taikhoan);
        }
       public bool update(Taikhoan taikhoan)
        {
            return _res.update(taikhoan);
        }
        public bool delete(string id)
        {
            return _res.delete(id);
        }
        //public bool Register(string taikhoan, string matkhau)
        //{
        //    return _res.Register(taikhoan,matkhau);
        //}

        //public bool Update(string hovaten,string diachi, string sdt , string tentaikhoan)
        //{
        //    return _res.Update(hovaten,diachi,sdt,tentaikhoan);
        //}

        //public Taikhoan GetInfo(string tentaikhoan)
        //{
        //    return _res.GetInfo(tentaikhoan);
        //}

        //public List<Taikhoan> GetAll()
        //{
        //    return _res.GetAll();
        //}

        //public bool DeleteById(string id)
        //{
        //    return _res.DeleteById(id);
        //}

        //public bool UpdateByAdmin(UpdateModelByAdmin model)
        //{
        //    return _res.UpdateByAdmin(model);
        //}

        //Taikhoan ITaikhoanBusiness.GetInfo(string tentaikhoan)
        //{
        //    throw new NotImplementedException();
        //}
    }
}