//using System;
//namespace program
//{ 
//public class ArmstrongExample
//{
//    public static void Main()
//    {
//        int n, r, sum = 0, temp;
//        Console.Write("Enter the Number= ");
//        n =Convert.ToInt32(Console.ReadLine());
//        temp = n;
//        while (n > 0)
//        {
//            r = n % 10;
//            sum = sum + (r * r * r);
//            n = n / 10;
//        }
//        if (temp == sum)
//            Console.Write("Armstrong Number.");
//        else
//            Console.Write("Not Armstrong Number.");
//    }
//}
//}