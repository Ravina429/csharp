using System;
using System.Collections.Generic;
namespace progrm
{

    class programm
    {
        delegate void del_display();
        public void display()
        {
            Console.WriteLine("I Love my Mom Dad");
        }
        static void main()
        {
            programm p1 = new programm();
            del_display d2 = new del_display(p1.display);
            d2();

        }
    }
}