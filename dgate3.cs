//using System;
//using System.Collections.Generic;
//namespace progr
//{
//    public delegate int del_square(int n1);
//    class program
//    { 
//        public int square(int n1)
//        {
//            return n1 * n1;
//        }
//        static void Main()
//        {
//            program p=new program();
//            del_square d1 = new del_square(p.square);
//            int res = d1(6);
//            Console.WriteLine("square=" + res);
//        }
//    }
//}