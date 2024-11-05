using System;
using System.Collections.Generic;

namespace Tuan7_Layout.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Phieudathang = new HashSet<Phieudathang>();
        }

        public string Makh { get; set; }
        public string Tenkh { get; set; }
        public int? Namsinh { get; set; }
        public bool? Phai { get; set; }
        public string Dienthoai { get; set; }
        public string Diachi { get; set; }
        public string Password { get; set; }

        public ICollection<Phieudathang> Phieudathang { get; set; }
    }
}
