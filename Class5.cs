using System;
namespace class5
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating....");
        }

    }
    public class dog:animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    class @program
    {
        static void Main()
        {
            animal a=new dog();

            a.eat();
        }
    }
}