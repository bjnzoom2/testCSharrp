using System;

class Program
{
    static void Main()
    {
        Dog doggy = new Dog("Max", 4);
        Console.WriteLine($"Name: {doggy.getName()}, Age: {doggy.getAge()}");
        doggy.bark(10);
    }
}

public class Dog
{
    public Dog(String name_, int age_)
    {
        this.name = name_;
        this.age = age_;
    }
    private String name;
    private int age;

    public void bark(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("Woof ");
        }
    }

    public String getName()
    {
        return this.name;
    }

    public int getAge()
    {
        return this.age;
    }
}