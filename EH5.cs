//using System;
//using System.Collections.Generic;
//namespace progr
//{
//    class Program
//    {
//        static void Main()
//        {
//            int age = 0;
//            try
//            {
//                Console.WriteLine("enter age");
//                age = Convert.ToInt32(Console.ReadLine());
//                if (age < 18)
//                {
//                    throw new Exception("age should be greater than 18 or equal to 18");
//                }
//            }
//            catch (Exception ee)
//            {
//                Console.WriteLine(ee.ToString());
//                Console.WriteLine("enter age 18 or greater than 18");
//                age = Convert.ToInt32(Console.ReadLine());
//            }
//            finally
//            {
//                Console.WriteLine("exicuting finally");
//                Console.WriteLine("age=" + age);
//            }
//            Console.WriteLine("bye");
//        }
//    }
//}