﻿//using System;
//namespace class3
//{
//    public class Person
//    {
//        String name;
//        String address;
//        protected internal void getPersonData(String name, String address)
//        {
//            this.name = name;
//            this.address = address;
//        }
//        protected internal void displayPersonData()
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
            
//            this.rno = rno;
//            this.marks = marks;
//        }
//        public void displayStudentData()
//        {
//                     Console.WriteLine("rno : " + rno);
//            Console.WriteLine("marks : " + marks);

//        }
//    }
//    class TestInheritance
//    {
//        public static void Main()
//        {
//            Student p1 = new Student();
//            p1.getPersonData("fasina", "nagpur");
//            p1.getStudentData(111, 999);
//            p1.displayStudentData();
//           p1.displayPersonData();


//        }
//    }

//}