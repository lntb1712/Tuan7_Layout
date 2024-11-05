using System;
using System.Collections.Generic;

namespace Tuan7_Layout.Models
{
    public partial class Loaihanghoa
    {
        public Loaihanghoa()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }

        public string Maloai { get; set; }
        public string Tenloai { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
