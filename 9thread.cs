using System;
using System.Threading;
namespace progr
{
    class Program
    {
        public static void calltochild()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread 0");
            }
        }
        public static void threadmethod()
        {
            for(int i=0; i <= 5; i++)
            {
                Console.WriteLine("Thread 1");
            }
        }
        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(calltochild));
            thread.Start(); 
            thread.Join(); 
            Thread thread1 = new Thread(new ThreadStart(threadmethod)); 
            thread1.Start(); 
            Console.ReadKey(); 
        
        }

    }
}