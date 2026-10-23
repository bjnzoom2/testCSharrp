using System;

class Program
{
    static void Main()
    {
        Skunk skunk1 = new Skunk();
        Crocodile crocodile1 = new Crocodile();

        crocodile1.ambush();
        skunk1.stink();
        skunk1.flee();
    }
}

interface IPrey
{
    void flee();
}

interface IPreadtor
{
    void hunt();
}

class Skunk : IPrey
{
    public void flee()
    {
        Console.WriteLine("Skunk ran away");
    }

    public void stink()
    {
        Console.WriteLine("Skunk released skink gas");
    }
}

class Crocodile : IPreadtor
{
    public void hunt()
    {
        Console.WriteLine("Crocodile searches for food");
    }

    public void ambush()
    {
        Console.WriteLine("Crocodile ambushes prey");
    }
}