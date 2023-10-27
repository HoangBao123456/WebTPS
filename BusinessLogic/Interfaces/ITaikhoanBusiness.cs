using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ITaikhoanBusiness
    {
        bool insert(Taikhoan taikhoan);
        bool update(Taikhoan taikhoan);
        bool delete(string id);
        //bool Update(string hovaten, string diachi, string sdt, string tentaikhoan);
        //bool delete(string id);
        ////Taikhoan GetInfo(string tentaikhoan);
        //List<Taikhoan> GetAll();

        //bool GetDataByUsername(string hovaten);


        //    bool DeleteById(string id);
        //    bool UpdateByAdmin(UpdateModelByAdmin model);
        //}
    }
}
