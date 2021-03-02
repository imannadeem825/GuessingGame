using System;

Main();

void Main()
{
    Console.Write("Guess the secret number: ");
    GuessNumber();
}


void GuessNumber()
{
    int secretNumber = 42;
    string userGuess = Console.ReadLine();
    int parsedAnswer = Int32.Parse(userGuess);

    if (string.IsNullOrWhiteSpace(userGuess))
    {
        Console.WriteLine("Take a guess, won't ya?");
    }
    else if (parsedAnswer == secretNumber)
    {
        Console.WriteLine("Nice job, you got it!");
    }
    else 
    {
        Console.WriteLine("Too bad, wrong answer!");
    }
}






// void GuessNumber()
// {
//     bool userGuess = ProgramAsks("Take a guess, won't ya?");
//     if (userGuess) 
//     {
        
//         string answer = Console.ReadLine();
//         Console.Write(answer)
//     }

// }


// bool ProgramAsks(string question)
// {
//     Console.Write($"{question}");
//     string answer = Console.ReadLine();
//     Console.Write(answer)
// }


// void ProgramSays(string message)
// {
//     Console.WriteLine($"{message}")
// }



