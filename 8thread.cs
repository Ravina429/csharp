//using System;
//using System.Threading;

//namespace progr
//{
//    class Program
//    {
//        public static void display()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine("i = " + i);
//                Thread.Sleep(500);
//            }
//        }
//        static void Main()
//        {
//            ThreadStart th = new ThreadStart(display);
//            Thread t1 = new Thread(th);
//            Thread t2 = new Thread(th);
//            t1.Start();
//            t1.Join();
//            t2.Start();
//        }
//    }
//}
