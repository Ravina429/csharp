﻿//using System;
//using System.Collections.Generic;
//namespace progre
//{
//    class publisher
//    {
//        public delegate void del1(int n1, int n2);
//        public event del1 event1;
//        public void raisevent()
//        {
//            if (event1!=null)
//            {
//                event1(2, 3);
//            }
//            else
//            {
//                Console.WriteLine("No Subscriber");
//            }
//        }


//    }
//    class program
//    {
//        public void addition(int n1,int n2)
//        {
//            int res = n1 + n2;
//            Console.WriteLine("Addition="+res);
//        }
//        static void Main()
//        {
//            publisher pub = new publisher();
            
//            pub.raisevent();
//        }
//    }
//}