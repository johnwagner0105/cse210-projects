using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberInt, sum = 0, largestNumber = 0, lowestNumber = int.MaxValue;
        double avr;
        bool iterator = true;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (iterator == true)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            numberInt = int.Parse(numberInput);
            if (numberInt == 0)
            {
                iterator = false;
            }
            else
            {
                numbers.Add(numberInt);
            }

        }
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number < lowestNumber && number > 0)
            {
                lowestNumber = number;
            }
        }
        avr = (double)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avr}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {lowestNumber}");
        numbers.Sort();
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }

    }
}