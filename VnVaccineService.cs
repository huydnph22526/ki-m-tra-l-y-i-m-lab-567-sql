
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class VnVaccineService
    {
        private List<VnVaccine> _lstVnVaccines;
        private VnVaccine _vaccine;
        private string _input;

        public VnVaccineService()
        {
            fakeData();
        }
        private void fakeData()
        {
            _lstVnVaccines = new List<VnVaccine> { new VnVaccine(1,"Abdala","CuBa",2021,6,"MRNA",18,"Còn 10 mũi"),
                new VnVaccine(2,"BBIBP-CorV","Sinopharm",2022,5,"MRNA",16,"Còn 10 mũi"),
                new VnVaccine(3,"Pfizer","ẤN Độ",2019,4,"MRNA",20,"Còn 10 mũi"),
                new VnVaccine(4,"Covaxin","Nhật Bản",2022,5,"MRNA",10,"Còn 10 mũi"),
                new VnVaccine(5,"Johnson & Johnson","Hàn Quốc",2021,3,"MRNA",15,"Còn 10 mũi"),
                new VnVaccine(6,"Moderna","Mỹ",2020,5,"MRNA",18,"Còn 10 mũi"),
                new VnVaccine(7,"AstraZeneca","Đức",2020,6,"MRNA",18,"Còn 10 mũi"),
                new VnVaccine(8,"Sputnik V","Nga",2019,5,"MRNA",14,"Còn 10 mũi"),
                new VnVaccine(9,"Vero Cell","Trung Quốc",2020,4,"MRNA",60,"Còn 10 mũi"),
                new VnVaccine(10,"SARS-CoV","Trung Quốc",2021,5,"MRNA",18,"Còn 10 mũi")
            };
        }
        public void Them()
        {
            _input = getInputValue("số lượng cần thêm: ");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _vaccine = new VnVaccine();


                _vaccine.MaVCC = _lstVnVaccines.Max(c => c.MaVCC) + 1;
                _vaccine.TenVCC = getInputValue("tên vaccine");
                _vaccine.NhaSX = getInputValue("tên nhà sản xuất");
                _vaccine.NamSX = Convert.ToInt32(getInputValue("năm sản xuất"));
                _vaccine.ThoiGianTacDung = Convert.ToInt32(getInputValue("thời gian tác dụng"));
                _vaccine.CongNghe = getInputValue("công nghệ");
                _vaccine.TuoiDuocPhepTiem = Convert.ToInt32(getInputValue("tuổi được phép tiêm"));
                _vaccine.GhiChu = getInputValue("ghi chú");
                _lstVnVaccines.Add(_vaccine);

            }
        }
        public void Sua()
        {

            _input = getInputValue("Nhập mã vaccine cần sửa: ");
            for (int i = 0; i < _lstVnVaccines.Count; i++)
            {
                if (_lstVnVaccines[i].MaVCC == Convert.ToInt32(_input))
                {

                    _lstVnVaccines[i].TenVCC = getInputValue("lại tên vaccine");
                    Console.WriteLine("Sửa thành công");

                    return;
                }
            }
            Console.WriteLine("Không tìm thấy ");
        }
        public void Xoa()
        {

            _input = getInputValue("Nhập mã vaccine cần sửa: ");
            for (int i = 0; i < _lstVnVaccines.Count; i++)
            {
                if (_lstVnVaccines[i].MaVCC == Convert.ToInt32(_input))
                {

                    _lstVnVaccines.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");

                    return;
                }
            }
            Console.WriteLine("Không tìm thấy ");
        }
        public void InDs()
        {
            foreach (var x in _lstVnVaccines)
            {
                x.InRaManHinh();
            }
        }
        public void SapXep()
        {
            //_lstVnVaccines = _lstVnVaccines.OrderByDescending(c => c.MaVCC).ToList();
            foreach (var x in _lstVnVaccines.OrderByDescending(c => c.MaVCC).ToList())
            {
                x.InRaManHinh();
            }
        }
        public string getInputValue(string mess)
        {
            Console.WriteLine($"Nhập {mess}: ");
            return Console.ReadLine();
        }
        //Lưu file
        public void SaveFile()
        {
            string path =
                @"C:\Users\Brown\Desktop\HuyDNPH22526_SM22_BL1_NET102\Assignment1\Data.bin";//ĐƯờng dẫn file lưu
            Console.WriteLine(FileService.SaveFile(path, _lstVnVaccines));
        }
        //Đọc file
        public void ReadFile()
        {
            string path =
                @"C:\Users\Brown\Desktop\HuyDNPH22526_SM22_BL1_NET102\Assignment1\Data.bin";//ĐƯờng dẫn file lưu
            _lstVnVaccines = new List<VnVaccine>();
            _lstVnVaccines = FileService.ReadFile(path);
        }



        //Lọc Vaccine (THEO THỜI GIAN TÁC DỤNG - TÊN THEO BẢNG CHỮ CÁI - THEO ĐỘ TUỔI ĐƯỢC PHÉP TIÊM sử dụng LINQ)
        public void LocTenTheoBangChuCai()
        {
            //var lstNameChuT =
            //   from a in _lstVnVaccines
            //   where a.TenVCC.StartsWith("A")
            //   select a;
            //foreach (var x in lstNameChuT)
            //{
            //    Console.WriteLine(x);
            //}
            Console.WriteLine("Lọc Vaccine THEO THỜI GIAN TÁC DỤNG");
            var ThoiGianTacDung =
                from a in _lstVnVaccines
                where a.ThoiGianTacDung <5
                select a;
            
            foreach (var x in ThoiGianTacDung)
            {
                x.InRaManHinh();
            }
            Console.WriteLine("Lọc Vaccine TÊN THEO BẢNG CHỮ CÁI");
            foreach (var x in _lstVnVaccines.ToList().Where(c => c.TenVCC.StartsWith("A")))
            {
                x.InRaManHinh();
            }
            Console.WriteLine("Lọc Vaccine THEO ĐỘ TUỔI ĐƯỢC PHÉP TIÊM");
            foreach (var x in _lstVnVaccines.ToList().Where(c => c.TuoiDuocPhepTiem >18).OrderByDescending(c=>c.TuoiDuocPhepTiem))
            {
                x.InRaManHinh();
            }
        }
        
        //Tìm kiếm (Tìm kiếm tên Vaccine gần đúng sử dụng LINQ)
        public void TimKiemTenGanDung() 
        {
            //_input = getInputValue("tên cần tìm kiếm");
            //var ThoiGianTacDung =
            //   from a in _lstVnVaccines
            //   where a.TenVCC.StartsWith(_input).OrderByDescending(c => c.TuoiDuocPhepTiem)
            //   where OrderByDescending(c => c.TuoiDuocPhepTiem)
            //   select a;

            //foreach (var x in ThoiGianTacDung)
            //{
            //    x.InRaManHinh();
            //}
            
        }
    }
}
