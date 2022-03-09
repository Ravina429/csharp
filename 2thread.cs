//using System;
//using System.Threading;
//namespace progr
//{
//    class Program
//    {
//        public static void calltochild()
//        {
//            Console.WriteLine("child thread starts");
//        }
//        static void Main()
//        {
//            ThreadStart td = new ThreadStart(calltochild);
//            Console.WriteLine("Main start:Creating a child thread");

//            Thread td1 = new Thread(td);
//            td1.Start();

//            Console.ReadKey();
//        }
//    }
//}