//using System;
//using System.Threading;
//namespace progr
//{
//    class program
//    {
//        public static void calltochild()
//        {
//            Console.WriteLine("child thread starts");
//            int sleepfor = 5000;

//            Console.WriteLine("child thread pause for {0}seconds", sleepfor/1000);
//            Thread.Sleep(sleepfor);
//            Console.WriteLine("child thread resumes");
//        }
//        static void Main()
//        {

//            ThreadStart td = new ThreadStart(calltochild);

//            Console.WriteLine("In Main Creataing a Child thread");

//            Thread ts=new Thread(td);
//            ts.Start();
//        }
//    }
//}