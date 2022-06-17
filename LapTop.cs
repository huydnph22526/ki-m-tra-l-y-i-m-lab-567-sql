using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenDe1
{
    [Serializable]
    internal class LapTop
    {
        public int MaLapTop { get; set; }
        public string Ten { get; set; }
        public double TrongLuong { get; set; }

        public LapTop()
        {

        }

        public LapTop(int maLapTop, string ten, double trongLuong)
        {
            MaLapTop = maLapTop;
            Ten = ten;
            TrongLuong = trongLuong;
        }
        public void inThongTin()
        {
            Console.WriteLine($"{MaLapTop}  {Ten}  {TrongLuong}");
        }
    }
}
