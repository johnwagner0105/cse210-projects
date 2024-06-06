using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("5/3/2023", 90, 3);
        Console.WriteLine(running.GetActivitySummary());

        Biking biking = new Biking("5/4/2023", 60, 15);
        Console.WriteLine(biking.GetActivitySummary());

        Swimming swimming = new Swimming("5/5/2023", 20, 3);
        Console.WriteLine(swimming.GetActivitySummary());
    }
}