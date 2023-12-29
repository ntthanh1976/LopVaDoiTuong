using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("900111", "Le Van Teo", 600);


            Console.Write("Inter id value:");
            string id = Console.ReadLine();

            Console.Write("Inter name value:");
            string name = Console.ReadLine();

            Console.Write("Inter balance value:");
            int  balance = int.Parse(Console.ReadLine());

            Account myFriend = new Account(id,name,balance);

            Console.WriteLine("-----Thong tin 2 tai khoan ban dau------");
            Console.WriteLine("My Account:[ id:{0}, name: {1}, balance: {2}]",
                 my.getId(), my.getName(),my.getBalance());
            Console.WriteLine("My friend Account:[ id:{0}, name: {1}, balance: {2}]",
                 myFriend.getId(), myFriend.getName(), myFriend.getBalance());

            int amount = 0;
            //rut tien
            Console.WriteLine("Debit 200 from My Account");
            my.debit(200);
            //chuyen tien
            Console.Write("Inter a amount value to tranfer:");
            amount = int.Parse(Console.ReadLine());
            //chuyen khoan tu tai khoan My den MyFriend
            my.tranferTo(myFriend, amount);

            //chuyen khoan tu tai khoan MyFriend den My
            myFriend.tranferTo(my, 50);

            //ket qua sau khi thuc hien mot so hanh vi (nap, rut, chuyen khoan)
            Console.WriteLine("-----Thong tin 2 tai khoan sau khi thuc hien giao dich-----");
            Console.WriteLine("My Account:[ id:{0}, name: {1}, balance: {2}]",
                 my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My friend Account:[ id:{0}, name: {1}, balance: {2}]",
                 myFriend.getId(), myFriend.getName(), myFriend.getBalance());

            Console.ReadLine();


        }
    }
}
