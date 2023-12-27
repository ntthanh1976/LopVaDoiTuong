using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1; //khai bao r1
            Rectangle r2; //khai bao r1

            r1 = new Rectangle(); //khoi tao r1

            Console.Write("Cho biet chieu dai:");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Cho biet chieu rong:");
            double width = double.Parse(Console.ReadLine());

            r2 = new Rectangle(length,width); //khoi tao r2

            Console.WriteLine("-------Thong tin hinh chu nhat r1-----------");
            Console.WriteLine("Chieu dai : {0}\nChieu rong: {1}\nDien tich: {2}\nChu vi: {3}", 
                r1.getLength(), r1.getWidth(), r1.findArea(), r1.findPerimeter());

            Console.WriteLine("-------Thong tin hinh chu nhat r2-----------");
            Console.WriteLine("Chieu dai : {0}\nChieu rong: {1}\nDien tich: {2}\nChu vi: {3}",
                r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPerimeter());

            //thay doi code
            Rectangle r3; //khai bao r1

            Console.ReadLine();

           

        }
    }
}
