using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_dulich
{
    internal class Program
    {
        class Program
        {
            static daily DanhsachDV;
            static void Menu()
            {
                try
                {
                    Console.WriteLine("Nhap tu 1-6 de thuc hien cac chuc nang sau:");
                    Console.WriteLine("1. Nhap Dich vu");
                    Console.WriteLine("2. Xuat Dichvu");
                    Console.WriteLine("3. Tim dich vu");
                    Console.WriteLine("4. Xoa dich vu");
                    Console.WriteLine("5. Sua dich vu");
                    Console.WriteLine(" ");
                    Console.Write("Nhap lua chon cua ban: ");
                    int menu = 0;
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            {
                                DanhsachDV.Nhap();
                                break;
                            }
                        case 2:
                            {
                                DanhsachDV.Xuat();
                                break;
                            }
                        case 3:
                            {
                                DanhsachDV.Tim().Xuat();
                                break;
                            }
                        case 4:
                            {
                                DanhsachDV.Xoa();
                                break;
                            }
                        case 5:
                            {
                                DanhsachDV.sua();
                                break;
                            }

                        default:
                            Console.WriteLine("Yeu cau nhap chuc nang menu tu 1-6 ");
                            Menu();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Co loi xay ra: " + ex.Message);
                }
            }
            static void Main(string[] args)
            {
                DanhsachDV = new daily();
                char c = 'y';
                while (c == 'y')
                {
                    Menu();
                    Console.WriteLine("Nhap ky tu 'y' de tro ve menu");
                    c = Convert.ToChar(Console.ReadLine().ToLower());
                }
            }
        }
    }

    
}
