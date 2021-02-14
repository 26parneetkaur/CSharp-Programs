using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    public class ProgramOne
    {
        public int Factorial(int factorialNumber)
        {
            if (factorialNumber == 0)
            {
                return 1;
            }
            else
            {
                return factorialNumber * Factorial(factorialNumber - 1);
            }
        }
        public int FactorialUsingFor(int x)
        {
            int result=1;
            for(int i=2;i<=x;i++)
            {
                result = result * i;
            }
            return result;
        }

        public int FactorialUsingWhile(int x)
        {
            if(x==0)
            {
                return 1;
            }
            int i = x, fact = 1;
            while( x / i != x)
            {
                fact = fact * i;
                i--;
            }
            return fact;
        }
        int temperature = 0;
        public void showTemp()
        {
            if(temperature==0)
            {
                throw (new TempIsZeroException("zero temperature found"));
            }
            else
            {
                Console.Write("temp is {0} " + temperature);
            }
        }
        public void callbyReference(ref int b)
        {
            b = b + 30;
            Console.WriteLine($"value after modification {b}");
        }
        public void callbyValue(string s1)
        {
            s1 = "This room is neat and clean";
            Console.WriteLine($"value after modification {s1}");
        }
        /*public unsafe void Method()
        {
                int x = 100;
                int* ptr = &x;
                Console.WriteLine((int)ptr);
            
        }*/
        /*public int deleteElement(int [] arr,int size,int el)
        {
            int i;
            for (i = 0; i < size; i++)
                if (arr[i] == el)
                    break;
            if(i<size)
            {
                size = size - 1;
                for(int j=i;j<size;j++)
                {
                    arr[j] = arr[j + 1];
                }
            }
            return size;
        }*/
        public int findElement(int [] arr,int p,int r)
        {
            for(int i=0;i<p;i++)
            {
                if(arr[i]==r)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            string temp = Console.ReadLine();
            int number = Convert.ToInt32(temp);
            Console.WriteLine("the number is {0}", number);
            int value, value1, value2;
            int[] arr = new int[10];
            ProgramOne n = new ProgramOne();
            value = n.Factorial(number);
            value1 = n.FactorialUsingFor(number);
            value2 = n.FactorialUsingWhile(number);
            Console.WriteLine("the factorial is {0}", value);
            Console.WriteLine("the Factorial of {0} is {1}", number, value1);
            Console.WriteLine("the Factorial using while of {0} is {1}", number, value2);
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 10;
            }
            foreach (int j in arr)
            {
                int i = j - 10;
                Console.WriteLine("element{0}={1}", i, j);
            }
            // Exception Handling...........
            var num1 = 5;
            var num2 = 0;
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
            //.................................
            //dynamic type--> when the value is being checked at run time as compaed to compile time..
            dynamic number1 = "Parneet Kaur";
            dynamic number2 = 123;
            dynamic number3 = 12.345;
            Console.WriteLine($"the type of number1 is {number1.GetType().ToString()}");
            Console.WriteLine($"the type of number2 is {number2.GetType().ToString()}");
            Console.WriteLine($"the type of number3 is {number3.GetType().ToString()}");

            //implicitly typed variables-->whose type is checked at complile time... eg using var ..
            var text1 = "This is horrible";
            var text2 = 123;
            var text3 = 12.34;
            Console.WriteLine($"the type of text1 is {text1.GetType()}");
            Console.WriteLine($"the type of text2 is {text2.GetType()}");
            Console.WriteLine($"the type of text3 is {text3.GetType()}");
            //math functions...
            Console.WriteLine($"the maximum value is {Math.Max(12, 34)}");
            Console.WriteLine($"the minimum value is {Math.Min(12, 34)}");
            Console.WriteLine($"the power is {Math.Pow(2,4 )}");
            Console.WriteLine($"the round off value is {Math.Round(12.52)}");
            //operators
            Console.WriteLine(number2 <<= 3);

            //call by reference
            int val = 20;
            //n.Method();
            unsafe
            {
                int x = 10;
                int* ptr;
                ptr = &x;

                // displaying value of x using pointer 
                Console.WriteLine("Inside the unsafe code block");
                Console.WriteLine("The value of x is " + *ptr);
            } // end unsafe block 

            Console.WriteLine("\nOutside the unsafe code block");
            // Console.WriteLine($"the address is {ref val}");
            Console.WriteLine($"value before call by reference is {val}");
            n.callbyReference(ref val);
            Console.WriteLine($"value after call by reference {val}");

            //call by value
            string s = "This room is messy";
            Console.WriteLine($"value before call by value {s}");
            n.callbyValue(s);
            Console.WriteLine($"value after call by value {s}");

            //searching an element from an array..........................
            int[] arr2 = new int[100];
            Console.WriteLine("enter the number of elements you want to store in an array");
            int p = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<p;i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine(arr2[i] + " ");
            }
            Console.WriteLine("enter the element which you want to search");
            int r = Convert.ToInt32(Console.ReadLine());
            int position = n.findElement(arr2, p, r);
            if(position==-1)
            {
                Console.WriteLine("element not found");
            }
            else
            {
                Console.WriteLine($"element is found at position {position}");
            }

            // making use of multidimensional arraay.............................
            int[,] multiarray = new int[5, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 }, { 12, 13, 14 } };
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine($"{i},{j},{multiarray[i,j]}");
                }
            }
            //jagged array.......................................................
            int[][] jaggedarr = new int[4][];
            jaggedarr[0] = new int[] { 1, 2, 3, 4 };
            jaggedarr[1] = new int[] { 4, 5, 6 };
            jaggedarr[2] = new int[] { 7 };
            jaggedarr[3] = new int[] { 8, 9, 4 };
            for(int i=0;i<jaggedarr.Length;i++)
            {
                Console.WriteLine($"row is: {i}");
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedarr[i][j]}");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
            Console.ReadKey();
        }
       
       
    }
}
