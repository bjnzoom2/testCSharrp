using System;

class Program
{
    static void Main()
    {
        Cat cat1 = new Cat("Lily", 2, "Maine Coon");
        Dog dog1 = new Dog("Max", 4, "German Sheperd");
        Console.WriteLine($"Cat, Name: {cat1.getName()}, Age: {cat1.getAge()}, Breed: {cat1.getCatBreed()}");
        Console.WriteLine($"Dog, Name: {dog1.getName()}, Age: {dog1.getAge()}, Breed: {dog1.getDogBreed()}");
        cat1.meow(10);
        dog1.bark(10);
        Console.WriteLine($"Number of pets: {Pet.getNumberOfPets()}");
    }
}

public abstract class Pet
{
    protected String name;
    protected int age;
    protected static int numberOfPets;

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

    public void meow(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write("Meow ");
        }
        Console.WriteLine();
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

    public void bark(int times)
    {
        for (int i = 0; i< times; i++)
        {
            Console.Write("Woof ");
        }
        Console.WriteLine();
    }

    public String getDogBreed()
    {
        return this.dogBreed;
    }
}