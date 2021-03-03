using System;

Main();

void Main()
{
    Console.Write("Guess the secret number: ");
    GuessNumber();
}


void GuessNumber()
{   
    for (int chances = 4; chances < 5 && chances > 0; chances--)

    {
        int secretNumber = 42;
        string userGuess = Console.ReadLine();


        while(string.IsNullOrEmpty(userGuess))
        {
            Console.WriteLine("Take a guess, won't ya?");
            userGuess = Console.ReadLine();
        }
        

        int parsedAnswer = Int32.Parse(userGuess);

        if (parsedAnswer == secretNumber)
        {
            Console.WriteLine("Nice job, you got it!");
        break;
        }
        else if (parsedAnswer > secretNumber)
        {
            Console.WriteLine("Try a lower number next time!");
        }
        else if (parsedAnswer < secretNumber)
        {
            Console.WriteLine("Try a higher number next time!");
        }
        else if (parsedAnswer != secretNumber && chances == 1) 
        {
            Console.WriteLine($"You have one last chance!");
        }
        else 
        {
            Console.WriteLine("Oh no! No chances left. Play again :)");
        }
        Console.WriteLine($"You have {chances - 1} chances left.");

    }
}


// string userAnswer = Console.ReadLine();
            
// while(string.IsNullOrEmpty(userAnswer))
// {
//     Console.WriteLine("Please choose a valid option.");
//     userAnswer = Console.ReadLine();
// }



// void ChancesToGuess()
// {
//     for (int chances = 4; chances < 5 && chances > 1; chances--) 
//     {
//         Console.WriteLine($"You have {chances - 1} chances left.");
//     }
//     for (int chances = 1; chances < 2 && chances > 0; chances--)
//     {
//         Console.WriteLine($"You have one last chance!");
//     }
// }


