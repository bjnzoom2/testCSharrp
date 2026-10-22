using System;

class Program
{
    static void Main(string[] args)
    {
        double opposite, adjacent;

        Console.Write("Enter opposite length:\n");
        opposite = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter adjacent length:\n");
        adjacent = Convert.ToDouble(Console.ReadLine());

        double hypotenuse = Math.Sqrt((opposite * opposite) + (adjacent * adjacent));
        Console.Write("Hypotenuse: " + hypotenuse + '\n');
    }
} 