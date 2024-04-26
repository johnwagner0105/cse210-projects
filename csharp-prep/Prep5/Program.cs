using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.Write("Welcome to the Program!");
        }
        String PromptUserName()
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.Write("Please, enter your favorite number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            return number;
        }
        int SquareNumber(int numberToSquare)
        {
            int number = numberToSquare * numberToSquare;
            return number;
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
    }
}