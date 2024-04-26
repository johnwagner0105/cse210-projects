using System;

class Program
{
    static void Main(string[] args)
    {
        bool newGame = true;
        while (newGame == true)
        {
            Random randomGenerator = new Random();
            int numberInt = randomGenerator.Next(1, 11);
            Console.Write("What is the magic number? ");
            // string number = Console.ReadLine();
            int counter = 0;
            // int numberInt = int.Parse(number);
            Console.Write("What is your guess? ");
            string numberGuess = Console.ReadLine();
            int numberIntGuess = int.Parse(numberGuess);
            do
            {
                if (numberInt < numberIntGuess)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    numberGuess = Console.ReadLine();
                    numberIntGuess = int.Parse(numberGuess);
                    counter += 1;
                }
                else if (numberInt > numberIntGuess)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    numberGuess = Console.ReadLine();
                    numberIntGuess = int.Parse(numberGuess);
                    counter += 1;
                }
            }

            while (numberInt != numberIntGuess);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed it in {counter + 1} attemps!");
            Console.Write("Do you want to play again? (y/n)");
            string newGameOption = Console.ReadLine();

            if (newGameOption == "n")
            {
                newGame = false;
            }
            else if (newGameOption == "y")
            {
                newGame = true;
            }

        }
        Console.WriteLine("Thank you for playing!");
    }
}