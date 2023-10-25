using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Kiem_Tra
{
    public class SinhVien
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }

        public override string ToString()
        {
            return maSV + "-" + hoTen + "-" + gioiTinh + "-" + diaChi;
        }
    }
}
