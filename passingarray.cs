using System;
namespace passingarray
{
    class @passingarray
    {
        static void Main()
        {
            int[] created = new int[3];
            created[0] = 1;
            created[1] = 2;
            created[2] = 3;

            CreateArray(created);
        }
        static void CreateArray(int[]array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

}