//using System;
//using System.Threading;
//namespace progr
//{
//    class Program
//    {
//        public void display()
//        {
//            for(int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("i="+i);
//                Thread.Sleep(1000);
//            }
//        }
//        static void Main()
//        {
//            Program p=new Program();
//            ThreadStart ts=new ThreadStart(p.display);

//            Thread td1 = new Thread(ts);
//            Thread td2 = new Thread(ts);
//            Thread td3 = new Thread(ts);

//            td1.Start();
//            td2.Start();
//                td3.Start();

//        }
//    }
//}