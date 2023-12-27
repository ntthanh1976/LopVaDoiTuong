using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoa01
{
    class HinhTron {
        //khai bao thuoc tinh 
        private double bankinh;       
        //dinh nghia phuong thuc khoi tao
        public HinhTron()
        {
            bankinh = 1.0;
        }
        public HinhTron(double bk)
        {
            bankinh = bk;
        }

        //dinh nghia phuong thuc cap nhat (setter)
        public void setBanKinh(double bk)
        {
            bankinh = Math.Abs(bk); 
        }

        //dinh nghia phuong thuc truy van (getter)
        public double getBanKinh()
        {
            return bankinh;
        }
        // dinh nghia cac phuong thuc tinh toan
        public double tinhDienTich()
        {
            return bankinh * bankinh * Math.PI; 
        }
        public double tinhChuVi()
        {
            return bankinh * 2 * Math.PI;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HinhTron c1 = new HinhTron(); //tao doi tuong hinh tron c1
            c1.setBanKinh(-3);
            Console.WriteLine("Hinh tron c1. Ban kinh={0}, Dien tich ={1}, Chu vi={2}",
               c1.getBanKinh(),  c1.tinhDienTich(), c1.tinhChuVi());           


            Console.Write("Cho biet ban kinh:");
            double bk = double.Parse(Console.ReadLine());
            HinhTron c2 = new HinhTron(bk);  
            
            Console.WriteLine("Hinh tron c2. Ban kinh={0}, Dien tich ={1}, Chu vi={2}", 
                c2.getBanKinh(), c2.tinhDienTich(), c2.tinhChuVi());

            Console.ReadLine();

        }
    }
}
