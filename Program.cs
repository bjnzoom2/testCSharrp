using System;

class Program
{
    static void Main(string[] args)
    {
        String name = "";

        while (name.Length < 1 && name[0] != ' ')
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello, " + name);

        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
    }
} 