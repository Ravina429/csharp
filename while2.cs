using System;
namespace while2
{
    class @while2
    {
        static void Main()
        {
            int i=0;
            while (i < 100) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadLine();

        }
    }
}