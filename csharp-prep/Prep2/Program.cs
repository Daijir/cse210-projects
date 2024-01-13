using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";        
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade % 10 >= 7 && grade < 90 && grade >= 60) 
        {
            letter += "+";
        }
        else if (grade % 10 < 3 && grade >= 60) 
        {
            letter += "-";
        }
        

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70) 
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}