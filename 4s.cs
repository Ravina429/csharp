//using System;
//namespace countvalue
//{
//    public class account
//    {
//        public int accno;
//        public string name;
//        public static int count;

//        public account(int accno,string name)
//        {
//            this.accno = accno;
//            this.name = name;
//            count++;

//        }
//        public void display()
//        {
//            Console.WriteLine(accno + " " + name + " ");
//        }
//    }
//    class @counttt
//    {
//        static void Main()
//        {
//            account a1 = new account(12,"Ina");
//            account a2 = new account(13, "mina");
//            account a3 = new account(14, "dika");

//            a1.display();
//            a2.display();
//            a3.display();

//            Console.WriteLine("Total instance count=" + account.count);
//        }
//    }
//}