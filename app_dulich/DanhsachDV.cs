using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace app_dulich
{   
    class DanhsachDV:DichVu
    {
        Dictionary<string, DanhsachDV> listaff;
        public DanhsachDV()
        {
            this.listaff = new Dictionary<string, DanhsachDV> ();
        }
        public  void Nhap()
        {
            char a = 'y';
            while (a == 'y')
            {
                DichVu dv = null;
                Console.WriteLine ("Chon nhap cac dich vu sau:");
                Console.WriteLine("1. Nhap Dia Diem.");
                Console.WriteLine("2. Nhap Hotel.");
                Console.WriteLine("3. Nhap Huong Dan Vien.");
                Console.WriteLine("4. Nhap Phuong tien.");
                Console.WriteLine(" ");
                int Func = int.Parse (Console.ReadLine());
                switch (Func)
                {
                    case 1:
                        {
                            dv = new Diadiem();
                            dv.Nhap();
                            break;
                        }
                    case 2:
                        {
                            dv = new Hotel();
                            dv.Nhap();
                            break;
                        }
                    case 3:
                        {
                            dv = new Huongdanvien();
                            dv.Nhap();
                            break;
                        }
                    case 4:
                        {
                            dv = new PhuongTien();
                            dv.Nhap();
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Vui lòng nhập lại !");
                            break;
                        }

                }
            }
        }
        public  void Xuat()
        {
            Console.WriteLine("Mã Dịch Vụ | Tên | Số Chứng minh | Phụ Cấp |");
            foreach (DanhsachDV dv in listaff.Values)
            {
                dv.Xuat();
            }
        }
        public DanhsachDV Tim()
        {
            Console.WriteLine("Nhap ma nv can tim:");
            String manv = Console.ReadLine();
            return this.listaff[id];
        }
        public void Xoa()
        {
            Console.WriteLine("Nhap ma nv can xoa:");
            String manv = Console.ReadLine();
            this.listaff.Remove(manv);
        }// end Xoa()

        public void sua()
        {
            DanhsachDV dv = this.Tim();
            Console.WriteLine("Nhập lựa chọn của bạn: ");
            Console.WriteLine("1. Sửa ID");
            Console.WriteLine("2. Sửa Tên");
            Console.WriteLine("3. Sửa  Mô Tả");
            Console.WriteLine("4. Sửa Hotline");
            Console.WriteLine("5. Sửa Địa chỉ");
            Console.WriteLine("6. Sửa Giá");

            Char t = 'y';
            while (t == 'y')
            {
                Console.Write("Nhap lua chon cua ban: ");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.Write("Nhập ID mới: ");
                            String tendichvu = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("NHập ID mới: ");
                            String ID = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập mô tả: ");
                            String mota = Console.ReadLine();
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Nhập Hotline: ");
                            String sdt = Console.ReadLine();
                            break;
                        }
                        case 5:
                        {
                            Console.Write("Nhập Địa chỉ: ");
                            String diachi = Console.ReadLine();
                            break;
                        }
                        case 6:
                        {
                            Console.Write("Nhập giá: ");
                            String giatien = Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("nhan y  de tiep tuc: ");
                        t = Convert.ToChar(Console.ReadLine());
                }
                listaff.Add(dv.id, dv);
            }
        }



    }
}
