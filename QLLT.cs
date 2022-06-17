using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenDe1
{
    internal class QLLT
    {
        private List<LapTop> _lstqllt;
        private LapTop _laptop;
        private string _input;

        public QLLT()
        {
            fakeData();
        }
        private void fakeData()
        {
            _lstqllt = new List<LapTop> { new LapTop(001,"Acer",11.2),
            new LapTop(002,"Dell",10.5),
            new LapTop(003,"Asus",12.1),
            new LapTop(004,"Macbook",9.9),
            new LapTop(005,"Lenovo",10)};
        }
        public void nhapdanhsach()
        {
            _input = GetInputValue("nhập số lượng");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _laptop = new LapTop();
                _laptop.MaLapTop = _lstqllt.Max(c=>c.MaLapTop)+1;
                _laptop.Ten = GetInputValue("tên laptop");
                _laptop.TrongLuong = Convert.ToDouble(GetInputValue("trọng lượng"));
                _lstqllt.Add(_laptop);
            }
            return;
        }
        public void xuatdoituong()
        {
            //XUẤT 1 ĐỐI TƯỢNG 
            foreach (var x in _lstqllt)
            {
                x.inThongTin();
            }
            ///XUẤT DANH SÁCH ĐỐI TƯỢNG
            //for (int i = 0; i < _lstqllt.Count; i++)
            //{
            //    _lstqllt[1].inThongTin();
            //    return;
            //}
        }
        public void xoalinq()
        {
            _input = GetInputValue("mã latop cần xóa");
            foreach (var x in _lstqllt.Where(c=>c.MaLapTop== Convert.ToInt32(_input)))
            {
                _lstqllt.Remove(x);
            }
        }
        public void loclinq ()
        {
            var loc = (from a in _lstqllt
                       where a.TrongLuong > 50 && a.Ten.StartsWith("a")
                       select a);
                       
        }
        public void sapxeplinq()
        {
            var sapxep = (from a in _lstqllt
                          orderby a.Ten descending
                          select a);
            foreach (var x in sapxep)
            {
                x.inThongTin();
            }
        }
        public void savefile()
        {
            string path = @"C:\Users\Brown\Desktop\HuyDNPH22526_SM22_BL1_NET102\LuyenDe1\GhiFile.bin";
            Console.WriteLine(FileService.SaveFile(path,_lstqllt));
        }
        public void readfile()
        {
            string path = @"C:\Users\Brown\Desktop\HuyDNPH22526_SM22_BL1_NET102\LuyenDe1\GhiFile.bin";
            _lstqllt = new List<LapTop>();
            FileService.ReadFile(path);
            
        }
        public string GetInputValue(string mess)
        {
            Console.WriteLine($"Mời bạn nhập {mess}: ");
            return Console.ReadLine();
        }
    }
}
