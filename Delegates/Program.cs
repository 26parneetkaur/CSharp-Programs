using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(int x, int y);
    public delegate Employee EmployeeDelegate();

    public class MyClass
    {
        public static void addNum(int x,int y)
        {
            Console.WriteLine($"sum is {x + y}");
        }
        public static void mulNum(int x,int y)
        {
            Console.WriteLine($"product is {x * y}");
        }
        public static Employee GetEmployee()
        {
            return new Employee();
        }
    }
    public class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int Age;
        public Employee() { }
        public Employee(string fName, string lName, int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = new MyDelegate(MyClass.addNum);
            MyDelegate del2 = new MyDelegate(MyClass.addNum);
            EmployeeDelegate emp = new EmployeeDelegate(MyClass.GetEmployee);
            Employee emp1 = emp();
            
            /*int result1 = del1(4, 5);
            Console.WriteLine("sum is : " + result1);
            MyDelegate del2 = new MyDelegate(MyClass.mulNum);
            int result2 = del2(2, 3);
            Console.WriteLine("product is : " + result2);*/
            del1 += new MyDelegate(MyClass.mulNum);
            //ccalling add and multtiply methods......
            del1(5, 10);
            del2 -= new MyDelegate(MyClass.mulNum);
            del2(10, 10);
            Console.ReadKey();
        }
    }
}
