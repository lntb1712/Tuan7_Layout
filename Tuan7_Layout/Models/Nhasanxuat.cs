using System;
using System.Collections.Generic;

namespace Tuan7_Layout.Models
{
    public partial class Nhasanxuat
    {
        public Nhasanxuat()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }

        public string Mansx { get; set; }
        public string Tennsx { get; set; }
        public string Diachi { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
