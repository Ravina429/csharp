//using System;
//using System.Collections.Generic;
//namespace projects
//{
//    class program
//    {
//        delegate void del_display();
//        public void display()
//        {
//            Console.WriteLine("hello delgate from method");
//        }
//        static void Main()
//        {
//            program p=new program();
//            del_display d1=new del_display(p.display);
//            d1();
//        }
//    }
//}