using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How old are you?\n");
        String textAge = Console.ReadLine();

        Console.Write("What is your name?\n");
        String name = Console.ReadLine();

        if (textAge != null && name != null)
        {
            Console.Write("You are " + name + ", and you are " + textAge + " years old this year.\n");
        }
    }
} 