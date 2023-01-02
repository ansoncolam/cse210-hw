using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int userInputInt = int.Parse(userInput);
        
        string letter;

        if (userInputInt >= 90) {
            letter = "A";
        } else if (userInputInt >= 80) {
            letter = "B";
        } else if (userInputInt >= 70) {
            letter = "C";
        } else if (userInputInt >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }

        string sign = "";

        if ((userInputInt < 97) && (letter != "F")) {
            if (userInputInt % 10 >= 7) {
                sign = "+";
            } else if (userInputInt % 10 < 3) {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (userInputInt >= 70) {
            Console.WriteLine("Congratulation! You passed the course!");
        } else {
            Console.WriteLine("Please work hard next time.");
        }


    }
}