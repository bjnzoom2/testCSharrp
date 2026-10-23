using System;

class Program
{
    static void Main()
    {
        Cat cat1 = new Cat("Lily", 2, "Maine Coon");
        Dog dog1 = new Dog("Max", 4, "German Sheperd");
        Console.WriteLine(cat1.ToString());
        Console.WriteLine(dog1.ToString());
        cat1.speak(10);
        dog1.speak(10);
        Console.WriteLine($"Number of pets: {Pet.getNumberOfPets()}");
    }
}

public abstract class Pet
{
    protected String name;
    protected int age;
    protected static int numberOfPets;

    public virtual void speak(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("ꙮ ");
        }
        Console.WriteLine();
    }

    public String getName()
    {
        return this.name;
    }

    public int getAge()
    {
        return this.age;
    }

    public static int getNumberOfPets()
    {
        return numberOfPets;
    }
}

public class Cat : Pet
{
    public Cat(String name_, int age_, String catBreed_) {
        this.name = name_;
        this.age = age_;
        this.catBreed = catBreed_;
        numberOfPets++;
    }

    private String catBreed;

    public override void speak(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("Meow ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"Cat, Name: {this.name}, Age: {this.age}, Breed: {this.catBreed}";
    }

    public String getCatBreed()
    {
        return this.catBreed;
    }
}

public class Dog : Pet
{
    public Dog(String name_, int age_, String dogBreed_)
    {
        this.name = name_;
        this.age = age_;
        this.dogBreed = dogBreed_;
        numberOfPets++;
    }

    private String dogBreed;

    public override void speak(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("Woof ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"Dog, Name: {this.name}, Age: {this.age}, Breed: {this.dogBreed}";
    }

    public String getDogBreed()
    {
        return this.dogBreed;
    }
}