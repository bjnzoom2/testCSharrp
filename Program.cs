using System;

class Program
{
    static void Main(string[] args)
    {
        int length, width;
        char symbol;

        Console.WriteLine("Enter rectangle length:");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter rectangle width:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter symbol to draw:");
        symbol = Console.ReadLine()[0];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(symbol);
            }
            Console.Write('\n');
        }
    }
} 