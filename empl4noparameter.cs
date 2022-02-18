////create a class employee having fields empno, empname, designation and salary
////create a constructor with no parameters and create another parameterized constructor with 4 parameters

//using System;
//namespace emp4para
//{
//    class empl
//    {
//        int empno;
//        string empname, desig;
//        int salary;

//        public empl()
//        {
//            empno = 11;
//            empname = "Ravina";
//            desig = "DotNet Developer";
//            salary = 40000;

//        }
//        public empl(int empno, string empname, string desig, int salary)
//        {
//            this.empno = empno;
//            this.empname = empname;
//            this.desig = desig;
//            this.salary = salary;
//        }
//        public void display()
//        {
//            Console.WriteLine("Enter Employee No. =" + empno);
//            Console.WriteLine("Enter Employee Name =" + empname);
//            Console.WriteLine("Enter Employee Designation =" + desig);
//            Console.WriteLine("Enter Employee Salary =" + salary);

//        }
//    }
//    class @empll
//    {
//        static void Main()
//        {
//            empl e = new empl();

//            e.display();
//            Console.WriteLine("---------Employee 1 Detail----------");

//            empl e1 = new empl(22, "Dolly", "HR", 20000);

//            e1.display();
//            Console.WriteLine("---------Employee 2 Detail----------");

//            Console.WriteLine("Enter employee no");
//            int empno = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter employee name ");
//            string empname = Console.ReadLine();

//            Console.WriteLine("Enter employee designation ");
//            string desig = Console.ReadLine();

//            Console.WriteLine("Enter employee salary");
//            int salary = Convert.ToInt32(Console.ReadLine());

//            empl e2 = new empl(empno, empname, desig, salary);


//            e2.display();
//            Console.ReadLine();

//        }
//    }
//}