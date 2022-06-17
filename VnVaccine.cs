using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    internal class VnVaccine : Vaccine
    {



        public string CongNghe { get; set; }
        public int TuoiDuocPhepTiem { get; set; }
        public string GhiChu { get; set; }

        public VnVaccine()
        {

        }

        public VnVaccine(int maVCC, string tenVCC, string nhaSX, int namSX, int thoiGianTacDung, string congNghe, int tuoiDuocPhepTiem, string ghiChu) : base(maVCC, tenVCC, nhaSX, namSX, thoiGianTacDung)
        {
            CongNghe = congNghe;
            TuoiDuocPhepTiem = tuoiDuocPhepTiem;
            GhiChu = ghiChu;
        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{MaVCC}  {TenVCC}  {NhaSX}  {NamSX} {ThoiGianTacDung} {CongNghe}  {TuoiDuocPhepTiem}  {GhiChu}");
        }

        
    }
}
