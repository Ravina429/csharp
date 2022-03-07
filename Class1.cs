using System;
namespace progr

{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating.....");
        }
       
    }
    public class dog:animal
    {
        public override void eat()
        {
           Console.WriteLine("eating bread.......");
        }
    }
}