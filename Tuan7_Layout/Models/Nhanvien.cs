using System;
using System.Collections.Generic;

namespace Tuan7_Layout.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Phieugiaohang = new HashSet<Phieugiaohang>();
        }

        public string Manv { get; set; }
        public string Tennv { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }
        public string Diachi { get; set; }
        public string Password { get; set; }

        public ICollection<Phieugiaohang> Phieugiaohang { get; set; }
    }
}
