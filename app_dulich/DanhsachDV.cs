using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace app_dulich
{   
    class DanhsachDV
    {
        Dictionary<String, DichVu> listDichVu;
        public DanhsachDV()
        {
            this.listDichVu = new Dictionary<string, DichVu> ();
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
<<<<<<< HEAD
                            dv.Nhap();
=======
                            dv .nhap();
                            break;
                        }
                    case 3:
                        {
                            dv = new Huongdanvien();
                            dv.nhap();
                            break;
                        }
                    case 4:
                        {
                            dv = new PhuongTien();
                            dv .nhap();
                            break;
                        }
                    default :
                        {
                            Console.WriteLine("Lua chon khong hop le! vui long nhap lai");
>>>>>>> 77cf64f8b89eb848e6f561e0117f8cf76746c200
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
               
                if (dv != null)
                {
                    this.listDichVu.Add(dv.idDichvu, dv);
                    Console.WriteLine("Nhap ky tu \"Y\" de tiep tuc.");
                    Console.WriteLine("Nhap \"N\" de thoat");
                    a=Convert.ToChar(Console.ReadLine());
                }

            }
        }
<<<<<<< HEAD
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
=======
        public void xuat()
        {

            foreach(DichVu dv in listDichVu.Values)
            {
                dv.xuat();
            }
        }
        public DichVu tim()
        {

            Console.Write("Tim dich vu: ");
            string IDDichVu = Console.ReadLine();
            return this.listDichVu[IDDichVu];

        }
        public void xoa()
        {
            DichVu dv = tim();
            String IDDichVu = Console.ReadLine();
            this.listDichVu.Remove(IDDichVu);
        }
        public void sua()
        {
            DichVu dv = tim();
            Console.WriteLine("Nhap lua chon cua ban: ");
            Console.WriteLine("1. Sua Ten");
            Console.WriteLine("2. Sua ID");
            Console.WriteLine("3. Sua Hotline");
            Console.WriteLine("4. Sua Dia chi");
            Console.WriteLine("5. Sua Mo ta");
            Console.WriteLine("6. Sua Gia");
            Console.WriteLine();
            Char t = 'y';
            while (t == 'y')
            {
                Console.Write("NHap lua chon cua ban: ");
                int chon =Convert.ToInt32(Console.ReadLine());
                switch (chon) 
                {
                    case 1:
                        {
                            Console.Write("Nhap ten: ");
                            string tendichvu = Console.ReadLine();
                            break;
                        }
                    case 2: 
                        {
                            Console.Write("Nhap ID: ");
                            string iDdichvu = Console.ReadLine();
>>>>>>> 77cf64f8b89eb848e6f561e0117f8cf76746c200
                            break;
                        }
                    case 3:
                        {
<<<<<<< HEAD
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
=======
                            Console.Write("Nhap Hotline: ");
                            int Hotline = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nhap Dia chi: ");
                            string diachi = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Nhap Dia chi: ");
                            string diachi = Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Nhap Gia: ");
                            double diachi = double.Parse(Console.ReadLine());
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Lua chon khong hop le! vui long nhap lai");
                            break;
                        }
                        Console.WriteLine("Nhap ky tu \"Y\" de tiep tuc.");
                        Console.WriteLine("Nhap \"N\" de thoat");
                        t = Convert.ToChar(Console.ReadLine());
                }
                listDichVu.Add(dv.idDichvu, dv);

>>>>>>> 77cf64f8b89eb848e6f561e0117f8cf76746c200
            }
        }


<<<<<<< HEAD

=======
>>>>>>> 77cf64f8b89eb848e6f561e0117f8cf76746c200
    }
}
