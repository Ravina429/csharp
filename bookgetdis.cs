////create a class book having member variables bookid , title, author, and price 
////and a method getdata() with no parameters , create another overloaded method getdata() with 4 parameters

//using System;
//namespace bookget
//{
//    class @book
//    {
//        int bookid;
//        String title, author;
//        int price;

//        public  void getdata ()
//        {
//            bookid = 12;
//            title = "Geeta";
//            author = "Vyasa";
//            price = 40000;
//        }
//        public void getdata(int bookid, String title, String author, int price)
//        {
//            this.bookid = bookid;
//            this.title = title; 
//            this.author = author;
//            this.price = price;

//        }
//        public void display()
//        {
//            Console.WriteLine("Book id = " + bookid);
//            Console.WriteLine("Book title = " + title);
//            Console.WriteLine("Book author= " + author);
//            Console.WriteLine("Price = " + price);

//        }
//    }
//    class @bookk
//    {
//        static void Main()
//        {
//            book b = new book();

//            b.getdata();
//            b.display();

//            Console.WriteLine("------------book 1detail------------");

//            book b1=new book();

//            b1.getdata(13,"Makhan","lalu",500);
//            b1.display();

//            Console.WriteLine("-------------book 2detail--------------");

//            Console.WriteLine("enter bookid");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter title");
//            String title = Console.ReadLine();
//            Console.WriteLine("enter author");
//            String author = Console.ReadLine();
//            Console.WriteLine("enter price");
//            int price = Convert.ToInt32(Console.ReadLine());

//            book b2=new book();

//            b2.getdata(id, title, author, price);
//            b2.display();
//            Console.ReadLine();


//        }
//    }
//}