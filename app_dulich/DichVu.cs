using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_dulich
{
     class DichVu
    {
        protected string id;
        protected string tendichvu;
        protected string mota;
        protected int sdt;
        protected string diachi;
        protected double giatien;

        public string ID { set { this.id = value; } get { return this.id; } }
        public string Tendichvu { set { this.tendichvu = value; } get { return this.tendichvu; } }
        public string Mota { set { this.mota = value; } get { return this.mota; } }
        public double Giatien { set { this.giatien = value; } get { return this.giatien; } }
        public int Sdt { set { this.sdt = value; } get { return this.sdt; } }
        public string Diachi { set { this.diachi = value; } get { return this.diachi; } }

        public DichVu() { }
        public DichVu(string id,string tendichvu, string mota, int sdt, string diachi, double giatien)
        {   
            this.id = id;
            this.tendichvu=tendichvu;
            this.mota=mota;
            this.sdt=sdt;
            this.diachi=diachi;
            this.giatien=giatien;
        }
        public virtual void Nhap()
        {

            Console.Write("Nhap ID: ");
            while (true)
            {
                string id = Console.ReadLine();
            
                if (KiemTraID(id))
                {
                    this.id = id;
                    break;
                }
                else
                {
                    Console.WriteLine("ID đã tồn tại. Vui lòng nhập lại!");
                }
            }
            Console.Write("Nhap ten dich vu: ");
            this.tendichvu = Console.ReadLine();
            Console.Write("Nhap mo ta dich vu : ");
            this.mota= Console.ReadLine();
            Console.Write("Nhap gia dich vu: ");
            this.Giatien = double.Parse(Console.ReadLine());
            while (true)
            {
                try
                {
                    Console.Write("Nhap gia dich vu: ");
                    string price = Console.ReadLine();
                    if(price.Length >999)
                    {
                        throw new FormatException("Gia phai la gia tri lon hon 1000. Vui long nhap lai!");
                    }
                    this.giatien=int.Parse(price);
                    break;
                }
                catch(FormatException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Nhap So dien thoai: ");
                    string Hotline = Console.ReadLine();
                    if (Hotline.Length != 10)
                    {
                        throw new FormatException("So dien thoai la mot day 10 chu so. Vui long nhap lai!");
                    }
                    this.sdt = int.Parse(Hotline);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("Nhap so dia thoai: ");
            this.sdt= int.Parse(Console.ReadLine());
            Console.Write("nhap dia chi : ");
            this.diachi=Console.ReadLine();
        }

        private bool KiemTraID(string id)
        {
            throw new NotImplementedException();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Id : " + this.id);
            Console.WriteLine("Dich cu : " + this.tendichvu);
            Console.WriteLine("Mo ta: "+ this.mota);
            Console.WriteLine("Gia : "+ this.Giatien);
            Console.WriteLine("Dia chi: " + this.Diachi);
            Console.WriteLine("hotline: " + this.Sdt);
        }
    }
}
