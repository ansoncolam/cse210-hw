using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopSwitch = false;
        int guesses = 0;

        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);

        while (loopSwitch == false) {
            guesses += 1;
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            int guessNumberInt = int.Parse(guessNumber);

            if (magicNumberInt > guessNumberInt) {
                Console.WriteLine("Higher");
            } else if (magicNumberInt < guessNumberInt) {
                Console.WriteLine("Lower");
            } else if (magicNumberInt == guessNumberInt) {
                Console.WriteLine("You guessed it!");
                if (guesses == 1) {
                    Console.WriteLine("You have made 1 guess only to get the answer!");
                } else {
                    Console.WriteLine($"You have made {guesses} guesses to get the answer!");
                }
                Console.WriteLine("Do you want to play again? ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes") {
                    magicNumberInt = randomGenerator.Next(1, 100);
                    guesses = 0;
                } else {
                    Console.WriteLine("Thanks for playing!");
                    loopSwitch = true;
                }
            }
        }

    }
}
