////-create a class book and constructor with no parameters and another constructor with 4 parameters

//using System;
//namespace cons4para
//{
//    class book2
//    {
//        int bookid;
//        String title, author;
//        int price;

//        public book2()
//        {
//            bookid = 1;
//            title = "oracle";
//            author = "james";
//            price = 250;

//        }
//        public book2(int bookid, string title, string author, int price)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            this.author = author;
//            this.price = price;
//        }
//        public void display()
//        {
//            Console.WriteLine("Book id=" + bookid);
//            Console.WriteLine("Title=" + title);
//            Console.WriteLine("Author=" + author);
//            Console.WriteLine("Book Price=" + price);
//        }
//    }
//    class @book
//    {
//        static void Main()
//        {
//            book2 b = new book2();

//            b.display();
//            Console.WriteLine("------------Book Detail---------------");

//            book2 b1 = new book2(2, "Love Story", "Austen", 500);

//            b1.display();
//            Console.WriteLine("----------------Book1 Detail-------------");

//            Console.WriteLine("Enter Bookid");
//            int id = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("enter title");
//            String title = Console.ReadLine();

//            Console.WriteLine("enter author");
//            String author = Console.ReadLine();

//            Console.WriteLine("enter price");
//            int price = Convert.ToInt32(Console.ReadLine());

//            book2 b2 = new book2(id, title, author, price);

//            b2.display();
//            Console.ReadLine();



//        }
//    }
//}