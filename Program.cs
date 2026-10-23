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
        this.name = name_;
        this.age = age_;
    }

    private String name;
    private int age;

    public String Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
    }
}