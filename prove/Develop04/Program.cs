using System;

class Program
{
    static void Main(string[] args)
    {
        string option;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathe.DisplayStartingMessage();
                    Console.Clear();
                    breathe.Run();
                    breathe.DisplayEndingMessage();
                    breathe.ShowSpinner(1);
                    Console.Clear();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                    reflection.DisplayStartingMessage();
                    Console.Clear();
                    reflection.Run();
                    reflection.DisplayEndingMessage();
                    reflection.ShowSpinner(1);
                    Console.Clear();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                    listing.DisplayStartingMessage();
                    Console.Clear();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    listing.ShowSpinner(1);
                    Console.Clear();
                    break;
            }
        } while (option != "4");




    }
}