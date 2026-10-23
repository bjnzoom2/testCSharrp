using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        char operatorSymbol;
        double result;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter equation symbol:");
        operatorSymbol = Console.ReadLine()[0];

        switch (operatorSymbol)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            case '%':
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result}");
    }
} 