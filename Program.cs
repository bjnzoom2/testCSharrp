using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        String computerMoveText;
        int playerMove = 0;
        int playerScore = 0;
        int computerScore = 0;

        while (true)
        {
            int computerMove = random.Next(1, 3);
            Console.WriteLine("Enter move (Rock/Paper/Scissors):");
            String playerMoveText = Console.ReadLine().ToLower();

            switch (playerMoveText)
            {
                case "rock":
                    playerMove = 1;
                    break;
                case "paper":
                    playerMove = 2;
                    break;
                case "scissors":
                    playerMove = 3;
                    break;
                default:
                    Console.WriteLine("Invalid Move");
                    return;
            }

            switch (computerMove)
            {
                case 1:
                    computerMoveText = "rock";
                    break;
                case 2:
                    computerMoveText = "paper";
                    break;
                case 3:
                    computerMoveText = "scissors";
                    break;
                default:
                    Console.WriteLine("Computer Error");
                    return;
            }

            Console.WriteLine("Player used " + playerMoveText + ". Computer used " + computerMoveText);

            if (playerMove == 1)
            {
                switch (computerMove)
                {
                    case 1:
                        Console.WriteLine("Tie");
                        break;
                    case 2:
                        Console.WriteLine("Computer Wins");
                        computerScore++;
                        break;
                    case 3:
                        Console.WriteLine("Player Wins");
                        playerScore++;
                        break;
                }
            }
            else if (playerMove == 2)
            {
                switch (computerMove)
                {
                    case 1:
                        Console.WriteLine("Player Wins");
                        playerScore++;
                        break;
                    case 2:
                        Console.WriteLine("Tie");
                        break;
                    case 3:
                        Console.WriteLine("Computer Wins");
                        computerScore++;
                        break;
                }
            }
            else if (playerMove == 3)
            {
                switch (computerMove)
                {
                    case 1:
                        Console.WriteLine("Computer Wins");
                        computerScore++;
                        break;
                    case 2:
                        Console.WriteLine("Player Wins");
                        playerScore++;
                        break;
                    case 3:
                        Console.WriteLine("Tie");
                        break;
                }
            }

            Console.WriteLine("\nPlayer score: " + playerScore + " | Computer score: " + computerScore + '\n');
        }
    }
} 