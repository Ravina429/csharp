﻿//using System;
//namespace class12
//{
//    public class Person
//    {
//        String name;
//        String address;
//        public void getPersonData(String name, String address)
//        {
//            this.name = name;
//            this.address = address;
//        }
//        public void displayPersonData()
//        {
//            Console.WriteLine("name : " + name);
//            Console.WriteLine("address : " + address);

//        }
//    }
//    public class Employee : Person
//    {
//        int salary;
//        String designation;
//        public void getEmployeeData(int salary, String designation)
//        {
          
//            this.salary = salary;
//            this.designation = designation;
//        }
//        public void displayEmployeeData()
//        {
//                     Console.WriteLine("salary : " + salary);
//            Console.WriteLine("designation : " + designation);

//        }
//    }

//    public class ParttimeEmployee : Employee
//    {
//        int no_of_hours;
//        public void getParttimeEmployeeData(int no_of_hours)
//        {
         
//            this.no_of_hours = no_of_hours;

//        }
//        public void displayparttimeEmployeeData()
//        {
//                      Console.WriteLine("no of hours  : " + no_of_hours);


//        }
//    }
//    class TestInheritance
//    {
//        public static void Main()
//        {
//            ParttimeEmployee p1 = new ParttimeEmployee();
//            p1.getPersonData("arifa", "nagpur");
//            p1.getEmployeeData(111, "manager");
//            p1.getParttimeEmployeeData(5);
//            p1.displayPersonData();
//            p1.displayEmployeeData();
//            p1.displayparttimeEmployeeData();

//        }
//    }

//}
