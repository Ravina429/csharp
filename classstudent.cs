//using System;
//namespace classstudent
//{
//    class student
//    {
//        int rno;
//        string name, course;
//        int fees;

//        public void getdata()
//        {
//            rno = 1;
//            name = "Monika";
//            course = "Java";
//            fees = 15000;
//        }
//        public void getdata(int rno)
//        {
//            this.rno = rno;
//        }
//        public void getdata(int rno,string name)
//        {
//            this.rno = rno;
//            this.name = name;
//        }
//        public void getdata(int rno,string name,string course)
//        {
//            this.rno = rno;
//            this.name = name;
//            this.course = course;
//        }
//        public void getdata(int rno, string name, string course,int fees)
//        {
//            this.rno = rno;
//            this.name = name;
//            this.course = course;
//            this.fees = fees;
//        }
//        public void display()
//        {
//            Console.WriteLine("enter student rno" + rno);
//            Console.WriteLine("enter student name" + name);
//            Console.WriteLine("enter student course"+ course);
//            Console.WriteLine("enter student fees"+ fees);
//        }
//    }
//    class @studentt
//    {
//        static void Main()
//        {
//            student s=new student();

//            s.getdata();
//            s.display();
//            Console.WriteLine("-------------student1 detail-----------");

//            student s1=new student();

//            s1.getdata(2, "Daddu");
//            s1.display();
//            Console.WriteLine("-------------student1 detail-----------");

//            student s2 = new student();

//            s2.getdata(2, "Daddu","Python");
//            s2.display();
//            Console.WriteLine("-------------student1 detail-----------");

//            student s3 = new student();

//            s3.getdata(2, "Daddu","Python",15000);
//            s3.display();
//            Console.WriteLine("-------------student1 detail-----------");

//            Console.ReadLine();
//        }
//    }
//}