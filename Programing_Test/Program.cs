using System;

namespace Programing_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Reverse.PrintReverse("AKHILESH");
            //FibonacciSeries.PrintFibonacci();
            //Palindrome.PrintPalindrome();
            //PrimeNumber.PrintPrime();
            //Factorial.PrintFactorial();

        }
    }


    /// <summary>
    /// Print Fibonacci series
    /// 
    /// 
    /// </summary>
    static class FibonacciSeries
    {
        public static void PrintFibonacci()
        {
            int first_no = 0, second_no = 1, result;
            int user_no;
            int count = 0;
            Console.WriteLine("Enter any number to PrintFibonacci:");
            user_no = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                result = first_no + second_no;
                count++;
                if (result >= user_no)
                { break; }
                first_no = second_no;
                second_no = result;
                Console.WriteLine("\nFibonacci No. [" + count + "] ->" + result);
            }
            Console.ReadKey(true);
        }
    }


    /// <summary>
    ///  Print Palindrome
    ///  
    /// 
    /// </summary>
    static class Palindrome
    {
        public static void PrintPalindrome()
        {
            string a, b;
            char[] charArray;

            Console.WriteLine("Enter the string to check if it is a panlindrome:");
            a = Console.ReadLine();
            b = a;
            charArray = a.ToCharArray();
            Array.Reverse(charArray);
            b = new string(charArray);
            if (a.Equals(b))
                Console.WriteLine("Entered string is a palindrome.");
            else
                Console.WriteLine("Entered string is not a palindrome.");

            Console.ReadKey(true);
        }
    }


    /// <summary>
    /// Print Prime Numbers:
    /// 
    /// 
    /// </summary>
    static class PrimeNumber
    {
        public static void PrintPrime()
        {
            int i;
            int j = 2;
            int ch = 0;
            Console.Write("\n Enter any number to PrintPrime:");
            i = Convert.ToInt32(Console.ReadLine());
            while (j <= i / 2)
            {
                if (i % j == 0)
                {
                    Console.WriteLine(i + " is not PRIME.");
                    ch = 1;
                    break;
                }
                else
                {
                    j++;
                }
            }
            if (ch == 0)
                Console.WriteLine(i + " is PRIME.");
            Console.ReadKey(true);
        }
    }

    
    /// <summary>
    /// Print Factorial
    /// 
    /// 
    /// </summary>
    static class Factorial
    {
        public static void PrintFactorial()
        {
            int n; //limit
            int cn; //current number
            int fact; //fact

            Console.Write("\n Enter a number to PrintFactorial:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Factorial of number between 1 to " + n + ":");
            Console.WriteLine("Number:Factorial");

            for (int i = 1; i <= n; i++)
            {
                cn = i;
                fact = 1;
                for (int j = 1; j <= cn; j++)
                {
                    fact = fact * j;
                }
                Console.Write("{0}:{1}\n", cn, fact);
            }
            Console.ReadKey(true);
        }
    }


    /// <summary>
    /// Print Reverse string without inbuild reverse function
    /// </summary>
    static class Reverse
    {
        public static void PrintReverse(string x)
        {
            Console.Write("\n Reverse string using PrintReverse function:");
            Console.Write("\n Entered string: " + x);
            char[] charArray = new char[x.Length];
            int len = x.Length - 1;
            for (int i = 0; i <= len; i++)
                charArray[i] = x[len - i];
            Console.Write("\n Reverse string is: " + new string(charArray));
            //return new string(charArray);
        }
    }
}
