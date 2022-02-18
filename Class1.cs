//using System;
//namespace diffrentpara
//{
//    class para
//    {
//        int bookid;
//        String title, author;
//        int price;

        
//        public void getdata(int bookid, int price)
//        {
//            this.bookid = bookid;
//            this.price = price;

//        }
//        public void getdata(int bookid, String title)
//        {
//            this.bookid = bookid;
//            this.title = title;


//        }
//        public void getdata(String title, String author)
//        {

//            this.title = title;
//            this.author = author;


//        }

//        public void display()
//        {
//            Console.WriteLine("book id = " + bookid);
//            Console.WriteLine("book title = " + title);
//            Console.WriteLine("book author= " + author);
//            Console.WriteLine("price = " + price);



//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            para b = new para();
//            b.getdata(1, 1200);
//            b.display();
//            Console.WriteLine("-----------------book1 details ----------");

//            para b1 = new para();
//            b1.getdata(1, "oracle");
//            b1.display();
//            Console.WriteLine("-----------------book1 details ----------");

//            para b2 = new para();
//            b2.getdata("oracle", "bill");
//            b2.display();
//            Console.WriteLine("-----------------book1 details ----------");


//            Console.ReadLine();

//        }
//    }

//}