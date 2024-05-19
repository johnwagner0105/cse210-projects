using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment01 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment01.GetSummary());

        MathAssignment assignment02 = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(assignment02.GetSummary());
        Console.WriteLine(assignment02.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}