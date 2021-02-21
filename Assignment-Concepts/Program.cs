using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Concepts
{
        //implementing interfaces.....
        public interface test
        {
            void show();
            int addSum(int x, int y);
        }
       public class Test1 : test
        {
            public void show()
            {
                Console.WriteLine("Welcome to the show method");
            }
            public int addSum(int x,int y)
            {
                int z = x * y;
                return z;
            }
        }
        //implementing abstract classes
        public abstract class template
        {
            public abstract void templateOne();
            public int nonabstract(int r)
            {
                int volume = r * r * r;
                return volume;
            }
        
        }
        public class sampleOne : template
        {
            public override void templateOne()
            {
                Console.WriteLine("welcome to class sample one");
            }
        }
        public class sampleTwo : template
        {
            public override void templateOne()
            {
                Console.WriteLine("welcome to class sample two");
            }
        }

    //constructors.....................
    public class Virtual
    {
        public string name1;
        public string model;
        public string color;
        public int year;
        //parameterised constructor
        public Virtual(string modelName)
        {
            name1 = modelName;

        }
        public Virtual(string modelOne, string colorName, int yearName)
        {
            model = modelOne;
            color = colorName;
            year = yearName;
        }

        //default constructor
        public Virtual()
        {
            string print = "welcome";
            Console.WriteLine($"this is a default constructor {print}");
        }

        private string topic_name;
        private int article_no;
        public Virtual(string topic_name, int article_no)
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
    class Example
    {
        public static int id = 10;
        public static void print()
        {
            Console.WriteLine("the value of id is : " + id);
        }
         static Example()
        {
            Console.WriteLine("this is a static constructor and is invoked automatically");
        }
    }

    //exception

    public class Fabb
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("zero temperature found"));
            }
            else
            {
                Console.Write("temp is {0} " + temperature);
            }
        }
    }
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    public class MyClass
    {
        public unsafe void method()
        {
            int x = 100;
            int y = 200;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);
            Console.WriteLine((int)ptr2);
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //interface
            Test1 t = new Test1();
            t.show();
            int val = t.addSum(10, 20);
            Console.WriteLine("the value of z is :- " + val);

            //abstract classes
            template obj;
            obj = new sampleOne();
            obj.templateOne();
            obj = new sampleTwo();
            obj.templateOne();
            int vol=obj.nonabstract(5);
            Console.WriteLine("the volume is : " + vol);

            //parameterised constructor
            Virtual v1 = new Virtual("heaven");
            Console.WriteLine(v1.name1);
            Virtual v2 = new Virtual("maruti", "black", 2000);
            Console.WriteLine(v2.model + " " + v2.color + " " + v2.year);

            //default constructor
            Virtual v3 = new Virtual();

            //copy constructor
            Virtual v4 = new Virtual("this is copy constructor", 300);
            Virtual v5 = new Virtual(v4);

            //static constructor
            Example.print();

            //try-catch-finally
            var num1 = 5;
            var num2 = 0;
            Fabb n = new Fabb();
            try
            {
                var num3 = num1 / num2;
                
                n.showTemp();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("this is an arthmetic divide by zero exception ");
                Console.WriteLine(e);
            }
            catch (TempIsZeroException e1)
            {
                Console.WriteLine("temperature is zero : {0}", e1.Message);
            }
            finally
            {
                Console.WriteLine("i have successfully reached finally block");
            }

            //making of pointers
            MyClass m = new MyClass();
            m.method();
            Console.ReadKey();
        }
    }
}
