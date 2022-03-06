//using System;
//namespace progr
//{
//    public class Account
//    {
//        public int accno;
//        public String name;
//        public static int count = 0;
//        public Account(int accno, String name)
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
//    class TestAccount
//    {
//        public static void Main()
//        {
//            Account a1 = new Account(101, "Sonu");
//            Account a2 = new Account(102, "Mahesh");
//            Account a3 = new Account(103, "suresh");
//            Account a4 = new Account(101, "Sonu");
//            Account a5 = new Account(102, "Mahesh");
//            Account a6 = new Account(103, "suresh");


//            a1.display();
//            Console.WriteLine("-------------------------------------");
//            a2.display();
//            Console.WriteLine("-------------------------------------");
//            a3.display();
//            Console.WriteLine("-------------------------------------");
//            a4.display();
//            Console.WriteLine("-------------------------------------");
//            a5.display();
//            Console.WriteLine("-------------------------------------");
//            a6.display();
//            Console.WriteLine("-------------------------------------");
//            Console.WriteLine("Total objects are=" + Account.count);
//        }
//    }
//}