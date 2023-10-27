using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Orders
    {
        public string id { get; set; }
        public string username { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string trangthai { get; set; }
    }

    public class OrderProductModel
    {
        public int id { get; set; }
        public int soluong { get; set; }
    }

    //List<OrderProductModel> lstProducts, Orders orders
    public class CreateOrderModel
    {
        public Orders orders { get; set; }
        public List<OrderProductModel> listProducts { get; set; }
    }

}
