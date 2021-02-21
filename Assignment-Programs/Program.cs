using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Programs
{
    class Program
    {
        //....................................
        public int reverse(int y)
        {
            int m = 0;
            while(y>0)
            {
                m = m * 10 + y % 10;
                y = y / 10;
            }
            return m;
        }
        public int check_pallindrome(int x)
        {
            int rev_no = reverse(x);
            if(rev_no==x)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //....................................
        public String reverse_string(string str)
        {
            int i = str.Length - 1;
            int start,end=i+1;
            String result = "";
            while(i>=0)
            {
                if(str[i]==' ')
                {
                    start = i + 1;
                    while(start!=end)
                    {
                        result += str[start++];
                    }
                    result += ' ';
                    end = i;
                }
                i--;
            }
            start = 0;
            while(start!=end)
            {
                result += str[start++];
            }
            return result;
        }
        //........................................................

        public static int contains_three(int numb)
        {
            while(numb>0)
            {
                if(numb%10==3)
                {
                    return 1;
                }
                numb = numb / 10;
            }
            return 0;
        }
        //.......................................................

        public static void reverseOrderArray(int[] arr,int size)
        {
            int i, k, temp;
            for( i=0;i<size/2;i++)
            {
                temp = arr[i];
                arr[i] = arr[size - i - 1];
                arr[size - i - 1] = temp;

            }
            Console.WriteLine("Reversed array is : ");
                for(k=0;k<size;k++)
                {
                Console.WriteLine(arr[k] + " ");
                }
        }
        static void Main(string[] args)
        {
            // 1. program to print diamond pattern..................
            int i, j, r;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("\n");

            Console.Write("Input number of rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            //.....................................................

            // 2. Program to swap two numbers without using 3rd variable..
            Console.WriteLine("Enter the numbers which you want to swap ");
            int number_one = Convert.ToInt32(Console.ReadLine()); ;
            int number_two = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine($"numbers before swapping are : {number_one} , {number_two}");
            number_one = number_one + number_two;
            number_two = number_one - number_two;
            number_one = number_one - number_two;
            Console.WriteLine($"numbers are swapped : {number_one} , {number_two}");
            //.......................................................

            // 3. Program to check whether the number is a pallindrome or not????
            Console.WriteLine("Enter the number which you want to check");
            Program p = new Program();
            int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.check_pallindrome(number) == 1 ? "Yes,its a pallindrome : )" : "No,It isn't : (");
            //................................................................

            // 4. Program to print the string in reverse order....................
            Console.WriteLine("Enter the string which you want to reverse");
            string s = Console.ReadLine();
            Console.WriteLine(p.reverse_string(s));
            //................................................................

            // 5. Program to check if the number contains digit 3 or not..........
            Console.WriteLine("Enter the number ");
            int num1 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine(contains_three(num1)==1 ? "yes,it contains" : "No,it doesnt");
            //.................................................................

            // 6. Program to reverse the order off array..........................
            int[] arr = new int[100];
            int m, n;
            Console.WriteLine("Enter the number of elements in an array");
            int size= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements which you want to insert..");
            for( m=0;m<size;m++)
            {
                arr[m]= Convert.ToInt32(Console.ReadLine());
            }
            for( m=0;m<size;m++)
            {
                Console.WriteLine(arr[m] + " ");
            }
            reverseOrderArray(arr, size);
            //.................................................................
            Console.ReadKey();
        }
    }
}
