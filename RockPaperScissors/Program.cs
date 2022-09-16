using System;
class program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        bool endGame = false;
        while (endGame != true)
        {
            game.TheGame();
            Console.WriteLine($"Player score: {game.PlayerScore}");
            Console.WriteLine($"Computer score: {game.ComputerScore}");
            Console.WriteLine("-------------------------------");
        }
    }
}

public class Game
{
    Player player = new Player();
    Computer computer = new Computer();

    // i used to have these two variables in TheGame() constructor, but i couldn't figure out
    // how to get them to update so i can have them print in main(). 
    public int PlayerScore;
    public int ComputerScore;

    public void TheGame()
    {
        while (true)
        {
            player.Choose();
            computer.Roll();

            // player chose rock
            if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.paper)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                ComputerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.scissors)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                PlayerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.rock)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                Console.WriteLine("tie!");
                break;
            }

            // player chose paper

            else if (player.current == rockpaperscissors.paper && computer.current == rockpaperscissors.rock)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                PlayerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.paper && computer.current == rockpaperscissors.paper)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                Console.WriteLine("Tie!");
                break;
            }
            else if (player.current == rockpaperscissors.paper && computer.current == rockpaperscissors.scissors)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                ComputerScore += 1;
                break;
            }

            // player chose scissors

            else if (player.current == rockpaperscissors.scissors && computer.current == rockpaperscissors.rock)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                PlayerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.scissors && computer.current == rockpaperscissors.paper)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                PlayerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.scissors && computer.current == rockpaperscissors.scissors)
            {
                Console.WriteLine($"The computer chose {computer.current}, you chose {player.current}");
                Console.WriteLine("Tie!");
                break;
            }
        }
    }

    public class Player
    {
        public rockpaperscissors current;
        public rockpaperscissors Choose()
        {
            Console.WriteLine("Do you want rock, paper, or scissors?");
            string? input = Console.ReadLine();
            if (input == "rock")
            {
                return current = rockpaperscissors.rock;
            }
            else if (input == "paper")
            {
                return current = rockpaperscissors.paper;
            }
            else if (input == "scissors")
            {
                return current = rockpaperscissors.scissors;
            }
            return current;
        }
    }

    public class Computer
    {
        public rockpaperscissors current;
        Random rnd = new Random();
        public rockpaperscissors Roll()
        {
            int number = rnd.Next(1, 4);
            if (number == 1) return current = rockpaperscissors.rock;
            else if (number == 2) return current = rockpaperscissors.paper;
            else if (number == 3) return current = rockpaperscissors.scissors;
            return current;
        }
    }
    public enum rockpaperscissors { rock, paper, scissors }
}