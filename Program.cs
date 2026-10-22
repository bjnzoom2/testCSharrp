using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter symbol");
        char symbol = Console.ReadLine()[0];

        switch (symbol)
        {
            case '@':
                Console.WriteLine("A");
                return;
            case '#':
                Console.WriteLine("B");
                return;
            case '$':
                Console.WriteLine("C");
                return;
            case '%':
                Console.WriteLine("D");
                return;
            default:
                Console.WriteLine("Unrecognised symbol.");
                return;
        }
    }
} 