//using System;
//using System.Collections.Generic;
//namespace progr
//{
//    public delegate int del1(int n1, int n2);
//    class program
//    {
//        public int addition(int n1, int n2)
//        {
//            return n1 + n2;
//        }
//        public int substraction(int n1,int n2)
//        {
//            return n1 - n2;
//        }
//        static void Main()
//        {
//            program p1 = new program();
//            del1 d1 = new del1(p1.addition);
//            int res = d1(3, 4);
//            Console.WriteLine("addtion="+res);
//            del1 d2 = new del1(p1.substraction);
//             res = d2(8, 4);
//            Console.WriteLine("substraction="+res);

//        }
        
//    }
//}