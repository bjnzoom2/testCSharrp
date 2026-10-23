using System;

class Program
{
    static void Main()
    {
        Vector<int, double> vector = new Vector<int, double>(1, 2.4);
        Console.WriteLine(vector);
    }
}

public class Vector<T, U>
{
    public Vector(T x_, U y_)
    {
        this.X = x_;
        this.Y = y_;
    }

    public T X
    {
        get; set;
    }

    public U Y
    {
        get; set;
    }

    public override string ToString()
    {
        return $"x = {X}, y = {Y}";
    }
}