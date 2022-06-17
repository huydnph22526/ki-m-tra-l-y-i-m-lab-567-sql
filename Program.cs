using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            VnVaccineService vaccine = new VnVaccineService();
            string input;
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.THÊM \n" +
                    "2.SỬA \n" +
                    "3.XÓA \n" +
                    "4.IN ĐỐI TƯỢNG \n" +
                    "5.Sắp xếp tăng hoặc giảm \n" +
                    "6.Lọc Vaccine (THEO THỜI GIAN TÁC DỤNG - TÊN THEO BẢNG CHỮ CÁI - THEO ĐỘ TUỔI ĐƯỢC PHÉP TIÊM sử dụng LINQ) \n" +
                    "7.Tìm kiếm (Tìm kiếm tên Vaccine gần đúng sử dụng LINQ) \n" +
                    "8.Đọc File \n" +
                    "9.Lưu File \n" +
                    "0.Thoát");
                Console.WriteLine("Mời bạn chọn:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        vaccine.Them();
                        break;
                    case "2":
                        vaccine.Sua();
                        break;
                    case "3":
                        vaccine.Xoa();
                        break;
                    case "4":
                        vaccine.InDs();
                        break;
                    case "5":
                        vaccine.SapXep();
                        break;
                    case "6":
                        vaccine.LocTenTheoBangChuCai();
                        break;
                    case "7":
                        vaccine.TimKiemTenGanDung();
                        break;
                    case "8":
                        vaccine.ReadFile();
                        break;
                    case "9":
                        vaccine.SaveFile();
                        break;
                    case "0":
                        Environment.ExitCode = 0;
                        break;
                    default:
                        Console.WriteLine("Mục bạn chọn không có vui lòng chọn lại");
                        break;
                }
            }

        }
    }
}
