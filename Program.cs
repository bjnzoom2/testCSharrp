using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int dice1 = random.Next(1, 6);
        int dice2 = random.Next(1, 6);
        int dice3 = random.Next(1, 6);

        int totalSum = dice1 + dice2 + dice3;

        Console.Write("3 dice are rolled. Guess the total sum of the numbers rolled on the dice.\n");
        int guessedSum = Convert.ToInt32(Console.ReadLine());

        if (guessedSum == totalSum)
        {
            Console.Write("You guessed correctly.\n");
        } else
        {
            Console.Write("You guessed incorrectly. The total sum was " + totalSum + ".\n");
        }
    }
} 