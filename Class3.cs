//using System;
//namespace class3
//{
//    public class Person
//    {
//        String name;
//        String address;
//        protected  void getPersonData(String name, String address)
//        {
//            this.name = name;
//            this.address = address;
//        }
//        protected  void displayPersonData()
//        {
//            Console.WriteLine("name : " + name);
//            Console.WriteLine("address : " + address);

//        }
//    }
//    public class Student : Person
//    {
//        int rno;
//        int marks;
//        public void getStudentData(int rno, int marks)
//        {
//            getPersonData("fasina", "nagpur");
//            this.rno = rno;
//            this.marks = marks;
//        }
//        public void displayStudentData()
//        {
//            displayPersonData();
//            Console.WriteLine("rno : " + rno);
//            Console.WriteLine("marks : " + marks);

//        }
//    }
//    class TestInheritance
//    {
//        public static void Main()
//        {
//            Student p1 = new Student();
            
//            p1.getStudentData(111, 999);
//            p1.displayStudentData();
            

//        }
//    }

//}