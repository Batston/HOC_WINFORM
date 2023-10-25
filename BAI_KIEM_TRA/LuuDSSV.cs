using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bai_Kiem_Tra
{
    public class LuuDSSV
    {
        public static List<SinhVien> DocFile(string path)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('|');
                    if(arr.Length == 4)
                    {
                        SinhVien sv = new SinhVien();
                        sv.maSV = arr[0];
                        sv.hoTen = arr[1];
                        sv.gioiTinh = arr[2];
                        sv.diaChi = arr[3];
                        dssv.Add(sv);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                
            }
            return dssv;
        }
    }
}
