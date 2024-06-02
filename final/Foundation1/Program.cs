using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Big Day", "Thomas the Tank", 1000);
        video1.AddComment("Bill", "Love that train!");
        video1.AddComment("Tim", "Choo Choo!");
        video1.AddComment("Sue", "Caused me confusion and delay");
        Video video2 = new Video("New House", "Bob the Builder", 1500);
        video2.AddComment("Bill", "Whish my tools talked too");
        video2.AddComment("Tim", "Looks a little sketchy to me");
        video2.AddComment("Sue", "Yes we can!");
        Video video3 = new Video("Catching a Roadrunner", "Willie E Coyote", 2000);
        video3.AddComment("Bill", "Where does he get all the TNT from?");
        video3.AddComment("Tim", "I thought only cats had 9 lives");
        video3.AddComment("Sue", "Beep Beep");

        video1.DisplayVideos();
        video2.DisplayVideos();
        video3.DisplayVideos();
    }
}