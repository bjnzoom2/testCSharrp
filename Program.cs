using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers do you want to sum up");
        int noOfValues = 0;

        try
        {
            noOfValues = Convert.ToInt32(Console.ReadLine());
        } catch (FormatException)
        {
            Console.WriteLine("Please enter an integer");
            return;
        }

        double[] values = new double[noOfValues];

        for (int i = 0; i < noOfValues; i++)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("Enter 1st number");
                    break;
                case 1:
                    Console.WriteLine("Enter 2nd number");
                    break;
                case 2:
                    Console.WriteLine("Enter 3rd number");
                    break;
                default:
                    Console.WriteLine($"Enter {i + 1}th number");
                    break;
            }

            try
            {
                values[i] = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Please enter a double");
                return;
            }
        }

        double sum = summation(values);
        Console.WriteLine($"Sum is {sum}");

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