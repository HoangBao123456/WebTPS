using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Taikhoan
    {
        public int id { get; set; }
        public string tentaikhoan { get; set; }
        public string matkhau { get; set; }
        public string level { get; set; }
        public int tien { get; set; }
        public string hovaten { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
       
    }

    public class AuthenticateModel
    {
        [Required]
        public string tentaikhoan { get; set; }

        [Required]
        public string matkhau { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        public string tentaikhoan { get; set; }
        [Required]
        public string matkhau { get; set; }
    }

    public class UpdateModel
    {
        [Required]
        public string hovaten { get; set; }
        [Required]
        public string sdt { get; set; }
        [Required]
        public string diachi { get; set; }
    }

    public class UpdateModelByAdmin
    {
        [Required]
        public string hovaten { get; set; }
        [Required]
        public string sdt { get; set; }
        [Required]
        public string diachi { get; set; }
        [Required]
        public string level { get; set; }
        [Required]
        public string tentaikhoan { get; set; }
    }

    public class AppSettings
    {
        public string Secret { get; set; }

    }
}