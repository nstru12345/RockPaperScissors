using System;
class program
{
    static void Main(string[] args)
    {
        Game game = new Game();

        bool endGame = false;
        while (endGame != true)
        {
            game.TheGame(0,0);
            Console.WriteLine($"Player score: {game.PlayerScore}");
            Console.WriteLine($"Computer score: {game.ComputerScore}");
            Console.WriteLine("-----------------");
        }
    }
}

public class Game
{
    Player player = new Player();
    Computer computer = new Computer();
    public int PlayerScore = 0;
    public int ComputerScore = 0;

    public void TheGame(int playerScore, int computerScore)
    {
        PlayerScore = playerScore;
        ComputerScore = computerScore;
        while (true)
        {
            player.Choose();
            computer.Roll();
            if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.paper)
            {
                computerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.scissors)
            {
                playerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.rock && computer.current == rockpaperscissors.rock)
            {
                Console.WriteLine("tie!");
                break;
            }
            else if (player.current == rockpaperscissors.paper && computer.current == rockpaperscissors.rock)
            {
                playerScore += 1;
                break;
            }
            else if (player.current == rockpaperscissors.paper && computer.current == rockpaperscissors.paper)
            {
                Console.WriteLine("Tie!");
                break;
            }
        }
    }
}

public class Player
{
    public rockpaperscissors current;
    public rockpaperscissors Choose()
    {
        Console.WriteLine("Do you want rock, paper, or scissors?");
        string input = Console.ReadLine();
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
        int number = rnd.Next(1, 3);
        if (number == 1) return current = rockpaperscissors.rock;
        else if (number == 2) return current = rockpaperscissors.paper;
        else if (number == 3)return current = rockpaperscissors.scissors;
        return current;
    }
}
public enum rockpaperscissors { rock, paper, scissors }
