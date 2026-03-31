using System;


class RockPaperScissorsGame
{

    static string[] options = ["Rock", "Paper", "Scissors"];

    static void printHeader()
    {
        Console.WriteLine();
        Console.WriteLine("ROCK PAPER SCISSORS GAME!");
        Console.WriteLine();        
    }

    static int readPlayerChoice()
    {
        String line = Console.ReadLine();
        int choice = Convert.ToInt32(line);
        return choice;       
    }

    static bool isChoiceValid(int choice)
    {
        return choice >= 0 && choice <= 2;
    }

    static int getComputerChoice()
    {
        Random random = new Random();
        return random.Next(0, 3);
    }

    static void checkResult(int computerChoice, int playerChoice)
    {
        int result = (computerChoice - playerChoice) % 3;
        if (result == 0)
        {
            Console.WriteLine("It's a draw!");
        } else if (result == 1)
        {
            Console.WriteLine("Computer wins!");
        } else
        {
            Console.WriteLine("Player wins!");
        }
    }

    static void printComputerChoice(int computerChoice)
    {
        Console.WriteLine("Computer choose: {0}", options[computerChoice]);
    }

    static void Main()
    {
        
        printHeader();

        while(true)
        {
            Console.WriteLine("Enter [0] -> Rock, [1] -> Paper, [2] -> Scissors:");

            int playerChoice = readPlayerChoice();

            if (isChoiceValid(playerChoice) == false) {
                Console.WriteLine("Valid choices are: [0] -> Rock, [1] -> Paper, [2] -> Scissors");
            } else
            {
                int computerChoice = getComputerChoice();
                printComputerChoice(computerChoice);
                checkResult(computerChoice, playerChoice);        
            }
        }

    }

}

/*

    Rock > Scissors
    Scissors > Paper
    Paper > Rock

    

*/