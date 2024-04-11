using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public class ReverseArray
{
    public int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    public void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    public void Reverse(int[] numbers)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            // Swap numbers[i] and numbers[length - i - 1]
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = temp;
        }
    }
}
