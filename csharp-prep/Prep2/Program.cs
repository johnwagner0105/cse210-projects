using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the percentage of your grade: ");
        string grade = Console.ReadLine();
        int gradeInNumber = int.Parse(grade);
        string finalGrade;
        if (gradeInNumber >= 90)
        {
            finalGrade = "A";
        }
        else if (gradeInNumber >= 80)
        {
            finalGrade = "B";
        }
        else if (gradeInNumber >= 70)
        {
            finalGrade = "C";
        }
        else if (gradeInNumber >= 60)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }

        if ((gradeInNumber % 10 >= 7) && finalGrade != "A" && finalGrade != "F")
        {
            finalGrade = finalGrade + "+";
        }
        else if ((gradeInNumber % 10 < 3) && finalGrade != "F")
        {
            finalGrade = finalGrade + "-";
        }
        Console.WriteLine($"Your grade is: {finalGrade}");
        if (gradeInNumber >= 70)
        {
            Console.WriteLine("Congratulations! Your passed!");
        }
        else
        {
            Console.WriteLine("I'm so sorry, you didn't pass, please study even harder next time!");
        }

    }
}