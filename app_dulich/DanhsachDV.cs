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
        public void Nhap()
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
                            dv.nhap();
                            break;
                        }
                    case 2:
                        {

                        }
                }
            }
        }
    }
}
