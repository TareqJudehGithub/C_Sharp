Console.WriteLine("Roll the Dice game\n");

bool isOver = false;
Random random = new Random();

int counter = 0;
RollDiceGame();

void RollDiceGame()
{

    do
    {
        // Roll the dice!
        int diceRoll = random.Next(1, 11);

        Console.WriteLine(diceRoll);

        Console.Write("What is your guess? ");
        bool isInt = int.TryParse(Console.ReadLine(), out int userGuess);

        if (isInt)
        {
            RollAndGuess(diceRoll, userGuess);
        }
        else
        {
            Console.WriteLine("Invalid entry!");
        }
        if (counter == 3)
        {
            Console.WriteLine("You ran out of attemps :(");
            isOver = true;

        }

    }
    while (isOver == false);
}
PlayAgain();

void RollAndGuess(int dice, int userGuess)
{

    if (dice == userGuess)
    {
        Console.WriteLine($"Congratulations! {userGuess} is the lucky number!");
        counter = 0;
        PlayAgain();
    }
    else if (dice != userGuess)
    {
        Console.Clear();
        Console.WriteLine("Wrong guess :(");
        counter++;
        Console.WriteLine($"counter now = {counter}");
        Console.WriteLine($"You have {3 - counter} attempts left.");
    }
}

void PlayAgain()
{
    Console.Write("Play again? (y/n) ");
    string userChoise = Console.ReadLine().ToLower();

    if (userChoise.Equals("n"))
    {
        Console.WriteLine("Game over!");
    }
    else
    {
        Console.Clear();
        RollDiceGame();
    }
}



