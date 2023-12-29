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
            Account myFriend = new Account("900112", "Tran Van Ti", 30);

            Console.WriteLine("-----Thong tin 2 tai khoan ban dau------");
            Console.WriteLine("My Account:[ id:{0}, name: {1}, balance: {2}]",
                 my.getId(), my.getName(),my.getBalance());
            Console.WriteLine("My friend Account:[ id:{0}, name: {1}, balance: {2}]",
                 myFriend.getId(), myFriend.getName(), myFriend.getBalance());

            //rut tien
            my.debit(200);
            my.tranferTo(myFriend, 410);


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
