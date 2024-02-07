using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            PrintFibonacciSeries(n);
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer for N.");
        }
    }

    static void PrintFibonacciSeries(int n)
    {
        int firstTerm = 0, secondTerm = 1;

        Console.WriteLine($"First {n} terms of the Fibonacci series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{firstTerm} ");

            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
