using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicetwo
{
    //getter and setter implementation...............
    public class Student
    {
        private string name = "PARNEET KAUR";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    //interface.................
    public interface test
    {
        void show();
        int sum(int x, int y);
    }
    class Myclass : test
    {
        public void show()
        {
            Console.WriteLine("this is show method");
        }
        public int sum(int x,int y)
        {
            int z = x * y;
            return z;
        }
    }
    //abstract class
    public abstract class template
    {
        public abstract void templateOne();
        public void nonAbstract()
        {
            Console.WriteLine("this is non-abstract class");
        }
    }
    public class sampleOne : template
    {
        public override void templateOne()
        {
            Console.WriteLine("welcome to the overridden abstract method SAMPLEONE..");
            
        }
    }
    public class sampleTwo : template
    {
        public override void templateOne()
        {
            Console.WriteLine("Welcome to SAMPLETWO");
            
        }
    }
    //constructors.....................
    public class Virtual
    {
        public string name1;
        public string model;
        public string color;
        public int year;
        public Virtual(string modelName)
        {
             name1 = modelName;
     
        }
        public Virtual(string modelOne,string colorName,int yearName)
        {
            model = modelOne;
            color = colorName;
            year = yearName;
        }
        public Virtual()
        {
            string print="welcome";
            Console.WriteLine($"this is a default constructor {print}");
        }

        private string topic_name;
        private int article_no;
        public Virtual(string topic_name,int article_no)
        {
            this.topic_name = topic_name;
            this.article_no = article_no;

        }
        //copy constructor
        public Virtual(Virtual v4)
        {
            topic_name = v4.topic_name;
            article_no = v4.article_no;
            Console.WriteLine($"the topic name is- {topic_name} and the article number is {article_no}");
        }

    }
    //Modifiers .......................
    public class Programone
    {
        public string model="lenovo";
        public void display()
        {
            Console.WriteLine("welcome to the public block");
        }
        public void display(int x,int y)
        {
            int a = x;
            int b = y;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"{a} , {b}");
        }
        public static int test(int x,int y)
        {
            return x + y;
        }
    }
    class Program
    {
        private string name="Parneet Kaur";
        private int num = 101;
        string gender;
        int rollno;
        string college;
        static void Main(string[] args)
        {
            //accessing private values...........
            Program one = new Program();
            Console.WriteLine(one.name);
            Console.WriteLine(one.num);
            //accessing public values............
            Programone o = new Programone();
            Console.WriteLine(o.model);
            o.display();
            o.display(5, 10);
            //static method......................
            int m=Programone.test(20, 14);
            Console.WriteLine($"the value of m is {m}");
            //making multiple objects and assigning values to it....
            one.gender = "female";
            one.rollno = 1217271;
            one.college = "jmit";
            Console.WriteLine($"{one.gender} ,{one.rollno},{one.college}");
            Program two = new Program();
            two.gender = "male";
            two.rollno = 1217281;
            two.college = "jmieti";
            Console.WriteLine($"{two.gender} ,{two.rollno},{two.college}");
            //parameterised constructor.............................
            Virtual v1 = new Virtual("heaven");
            Console.WriteLine(v1.name1);
            Virtual v2 = new Virtual("maruti", "black", 2000);
            Console.WriteLine(v2.model + " " + v2.color + " " + v2.year);
            //default constructor..................................
            Virtual v3 = new Virtual();
            //copy constructor
            Virtual v4 = new Virtual("this is copy constructor", 300);
            Virtual v5 = new Virtual(v4);

            //abstract classes......................................
            template obj;
            obj = new sampleOne();
            obj.templateOne();
            obj = new sampleTwo();
            obj.templateOne();
            obj.nonAbstract();
            //..........................................................
            //interfaces implementation.................................
            Myclass ob1 = new Myclass();
            ob1.show();
            int val=ob1.sum(20, 10);
            Console.WriteLine(val);
            //getter and setter method..................................
            Student s = new Student();
            s.Name = "Parneet Kaur Vig";
            Console.WriteLine("Name is:" + s.Name); 
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
