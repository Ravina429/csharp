//using System;
//using System.Threading;
//namespace progr
//{
//    class Program
//    {
//        public void display()
//        {
//            for(int i = 0; i <= 25; i++)
//            {
//                Console.WriteLine("i= " + i);
//            }
//        }
//        static void Main()
//        {
//            Program p=new Program();
//            ThreadStart td=new ThreadStart(p.display);
//            Thread t1 = new Thread(td);
//            Thread t2=new Thread(td);
//            Thread t3=new Thread(td);
//            Thread t4=new Thread(td);

//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t4.Start();
//        }
//    }
//}