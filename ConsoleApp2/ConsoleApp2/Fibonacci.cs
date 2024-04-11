using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;
public class Fibonacci
{
    public void PrintFibonacci()
    {
        Console.WriteLine("First 10 numbers of the Fibonacci sequence:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}): {GetFibonacci(i)}");
        }
    }

    public int GetFibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1; // Base case: first two Fibonacci numbers are both 1
        }
        else
        {
            // Recursively call Fibonacci to calculate the sum of the previous two Fibonacci numbers
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}

