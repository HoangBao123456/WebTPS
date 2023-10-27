using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer.Interfaces
{
    public partial interface ITaikhoanRepository
    {
        bool insert(Taikhoan taikhoan);
        bool update(Taikhoan taikhoan);
        bool delete(string id);
        

    }
}
