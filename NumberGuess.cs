using System;

class NumberGuess
{
    
    static void printHeader()
    {
        Console.WriteLine();
        Console.WriteLine("NUMBER GUESS GAME!");
        Console.WriteLine("Enter a number from 0 to 100:");
        Console.WriteLine();        
    }

    static int readChoice()
    {
        String line = Console.ReadLine();
        int choice = Convert.ToInt32(line); 
        return choice;       
    }

    static bool checkChoice(int choice, int num)
    {
        bool result = false;

        if (choice == num)
        {
            Console.WriteLine("You guessed it! The correct number is {0}", num);
            result = true;
        } else if (choice > num)
        {
            Console.WriteLine("Your number is greater than the correct number!");
        } else
        {
            Console.WriteLine("Your number is less than the correct number!");
        }   

        return result;     
    }

    static void Main()
    {

        printHeader();

        int num = 67;
        bool scored = false;
        
        while(scored == false)
        {

            int choice = readChoice();
            
            scored = checkChoice(choice, num);
           

        }

        Console.WriteLine("Game Over!");
    }
}