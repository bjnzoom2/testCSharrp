using System;

class Program
{
    static void Main(string[] args)
    {
        String[] data = new string[3];

        Console.WriteLine("What is your name");
        data[0] = Console.ReadLine();
        Console.WriteLine("How old are you");
        data[1] = Console.ReadLine();
        Console.WriteLine("Where do you live");
        data[2] = Console.ReadLine();

        Console.WriteLine();

        foreach (String dataPiece in data)
        {
            Console.WriteLine(dataPiece);
        }
    }
} 