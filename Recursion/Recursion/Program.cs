using System;
using System.Numerics;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("[1] Factorial");
            Console.WriteLine("[2] Fibonacci");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        try
                        {
                            Console.WriteLine("Enter a number");
                            BigInteger num = BigInteger.Parse(Console.ReadLine());
                            Console.WriteLine($"The factorial of {num} is {Factorial(num)}");
                        }
                        catch
                        {
                            Console.WriteLine("Input not in the correct format, please enter an integer!");
                        }
                        break;



                    case 2:
                        try
                        {
                            Console.WriteLine("Enter a number");
                            int num = int.Parse(Console.ReadLine());
                            num--;
                            Console.WriteLine($"The {num}th Fibonacci number is {Fibonacci(num)}");
                        }
                        catch
                        {
                            Console.WriteLine("Input not in the correct format, please enter an integer!");
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Please enter a valid choice, error code: " +
                    "" + e.ToString());
                
            }
        }

        static BigInteger Factorial(BigInteger num)
        {
            if (num == 0 || num == 1)
            {
                return 1; // stopping condition
            }

            else
            {
                return num * Factorial(num - 1);
            }
        }


         static int Fibonacci(int n)
        {
            
            if (n == 0 || n == 1)
            {
                return 1; // stopping condition
            }

            if (n > 1)
            {


                n = Fibonacci(n - 1) + Fibonacci(n - 2);
                return n;

            }
            return -1;
        }
    }
}
