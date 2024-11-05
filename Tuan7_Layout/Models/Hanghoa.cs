using System;
using System.Collections.Generic;

namespace Tuan7_Layout.Models
{
    public partial class Hanghoa
    {
        public Hanghoa()
        {
            Chitietphieudathang = new HashSet<Chitietphieudathang>();
            Chitietphieugiaohang = new HashSet<Chitietphieugiaohang>();
        }

        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Donvitinh { get; set; }
        public double? Dongia { get; set; }
        public string Hinh { get; set; }
        public string Maloai { get; set; }
        public string Mansx { get; set; }

        public Loaihanghoa MaloaiNavigation { get; set; }
        public Nhasanxuat MansxNavigation { get; set; }
        public ICollection<Chitietphieudathang> Chitietphieudathang { get; set; }
        public ICollection<Chitietphieugiaohang> Chitietphieugiaohang { get; set; }
    }
}
