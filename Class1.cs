﻿//using System;
//using System.Collections.Generic;
//namespace progr
//{
//    class publisher
//    {
//        public delegate void del1(int n1, int n2);
//        public event del1 event1;
//        public void raisevent(int n1, int n2)
//        {
//            if(event1 != null)
//            {
//                event1(n1,n2);
//            }
//            else
//            {
//                Console.WriteLine("no subscriber");
//            }
//        }
//    }
//    class program
//    {
//        public void addition(int n1, int n2)
//        {
//            int res = n1 + n2;
//            Console.WriteLine("additiom="+res);
//        }
//        static void Main()
//        {
//            publisher pub = new publisher();
//            pub.raisevent(2,1);
//        }

//    }
//}