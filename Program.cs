using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        int guessedNumber = 0;
        int tries = 0;

        while (guessedNumber != randomNumber)
        {
            Console.WriteLine("Guess a number through 1 to 100");
            guessedNumber = Convert.ToInt32(Console.ReadLine());
            tries++;

            if (guessedNumber > randomNumber)
            {
                Console.WriteLine(guessedNumber + " is too high. Try again");
                continue;
            } else if (guessedNumber < randomNumber)
            {
                Console.WriteLine(guessedNumber + " is too low. Try again");
                continue;
            }
        }

        Console.WriteLine("You guessed correctly. It took " + tries + " tries");
    }
} 