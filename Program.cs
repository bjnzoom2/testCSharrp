using System;

class Program
{
    static void Main(string[] args)
    {
        String name = "Friedrich-Wilhelm Nikolaus Karl Heinrich Alexander Augustus Emmanuel von Saxe-Coburg-Gotha-Hohenzollern-Sigmaringen The Third";
        String phoneNumber = "(+0) 123-456-789";

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine(phoneNumber.Replace('-', '_'));

        String email = name.Insert(name.Length, "@gmail.com");
        Console.WriteLine(email);

        String newName = name.Substring(0, 9);
        Console.WriteLine(newName);
    }
} 