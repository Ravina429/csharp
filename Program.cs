using System;
namespace volumelbh
{
    class Program
    {
        static void Main()
        {
            int l, b, h, volume;
            Console.WriteLine("enter the value of length");
            l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of breadth");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of height");
            h=Convert.ToInt32(Console.ReadLine());
            volume = l * b * h;
            Console.WriteLine("volume= " + volume);
            Console.ReadLine();
        }
    }
}