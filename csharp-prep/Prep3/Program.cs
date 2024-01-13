using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sum = 0;
        double average;
        int largestNumber;
        int smallestPositiveNumber;

        while (true) 
        {
            Console.Write("Enter number:  ");
            string stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
            sum += number;
        }

        average = numbers.Average();
        largestNumber = numbers.Max();
        smallestPositiveNumber = numbers.Where(n => n > 0).Min();

        Console.WriteLine($"The sum is:  {sum}");
        Console.WriteLine($"The average is:  {average}");
        Console.WriteLine($"The smallest positive number is:  {smallestPositiveNumber}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (var n in numbers)
        {
            Console.WriteLine($"{n}");
        }
    }
}