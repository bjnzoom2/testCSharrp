using System;

class Program
{
    static void Main()
    {
        Human human = new Human("Lucas ng", 14);
        Console.WriteLine(human.Age);
        human.Name = "Mily";
        Console.WriteLine(human.Name);
    }
}

class Human
{
    public Human(String name_, int age_) {
        this.Name = name_;
        this.age = age_;
    }
    private int age;

    public String Name
    {
        get; set;
    }

    public int Age
    {
        get
        {
            return age;
        }
    }
}