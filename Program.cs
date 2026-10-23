using System;

class Program
{
    static void Main(string[] args)
    {
        double sum = summation(1.0, 2.0, 5.0, 3.14159, 2.712);
        Console.WriteLine(sum);

        print("Hello", 3, true);
    }

    static double summation(params double[] values)
    {
        double sum = 0;
        foreach (double value in values)
        {
            sum += value;
        }

        return sum;
    }

    static void print(String str)
    {
        Console.Write(str);
    }

    static void print(String str, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write(str);
        }
    }

    static void print(String str, int times, bool whitespace)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write(str);
            if (whitespace)
            {
                Console.Write(' ');
            }
        }
    }
} 