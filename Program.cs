using System;

class Program
{
    static void Main()
    {
        List<int> values = new List<int>();
        for (int i = 0; i <= 1000; i++)
        {
            values.Add(i);
        }

        values.RemoveRange(100, 200);
        values.Insert(100, 999999999);
        values.Reverse();

        foreach (int value in values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine(values.Count);
        Console.WriteLine(values.Contains(100));
    }
}