using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenDe1
{
    internal class Program
    {

        private static void Menu()
        {
            QLLT qLLT = new QLLT();

            Console.WriteLine("nhập danh sách đối tượng \n" +
                "xuất danh sách \n" +
                "lưu file \n" +
                "đọc file \n" +
                "xóa đối tượng \n" +
                "lọc \n" +
                "sắp xếp \n");
            Console.WriteLine("Mời bạn chọn: ");
            string input = Console.ReadLine();
            do
            {
                switch (input)
                {
                    case "1":
                        qLLT.nhapdanhsach();
                        break;

                    case "2":
                        qLLT.xuatdoituong();
                        break;
                        
                    case "3":
                        qLLT.savefile();
                        break;
                    case "4":
                        qLLT.readfile();
                        break;
                    case "5":
                        qLLT.xoalinq();
                        break;
                    case "6":
                        qLLT.loclinq();
                        break;
                    case "7":
                        qLLT.sapxeplinq();
                        break;
                    case "0":
                        Console.WriteLine("bạn chọn thoát");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mục bạn chọn không có vui lòng chọn lại");
                        break;
                }
            } while (input != "0");


        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Action action = Menu;
            action();
            
        }
    }
}
