//using System;
//namespace class4
//{
//    interface bank
//    {
//        string deposit(int acno, int amt);
//    }
//    class saving : bank
//    {
//        int acno;
//        int balance = 100;
//       public string deposit (int acno,int amt)
//        {
//            this.acno = acno;
//            balance = balance + amt;
//            return "deposited succsesfully successfully,bal is" + balance;
//        }
//    }
//    class @program
//    {
//        static void Main()
//        {
//            bank b=new saving();

//            string str = b.deposit(1, 200);
//            Console.WriteLine(str);
//        }
//    }
//}