using System;

class Program
{
    static void Main(string[] args)
    {
        String[,] data = { {"Abby", "14", "Brooklyn", "Ice cream"},
                           {"Brandon", "12", "Germany", "Cheesecake"},
                           {"Harmony", "13", "Singapore", "Chocolate"} };

        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                switch (j)
                {
                    case 0:
                        Console.Write("Name: ");
                        break;
                    case 1:
                        Console.Write("Age: ");
                        break;
                    case 2:
                        Console.Write("Lives in: ");
                        break;
                    case 3:
                        Console.Write("Favourite desert: ");
                        break;
                }

                Console.Write($"{data[i, j]}, ");
            }

            Console.WriteLine();
        }
    }
} 