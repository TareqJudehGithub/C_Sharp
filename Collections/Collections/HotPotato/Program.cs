// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hot Potato Simulation Game\n");

Run();

static void PlayHotPotatoGame(int numberOfPlayers, int eliminationInterval)
{
    Queue<string> playersQueue = new Queue<string>();

    for (int i = 1; i <= numberOfPlayers; i++)
    {
        playersQueue.Enqueue($"Player {i}");
    }

    // Keep track of eliminated players throughout the game
    Stack<string> eliminatedPlayers = new Stack<string>();

    while (playersQueue.Count > 1)
    {
        for (int i = 0; i < eliminationInterval; i++)
        {
            string currentPlayer = playersQueue.Dequeue();
            playersQueue.Enqueue(currentPlayer);
        }
        string eliminatedPlayer = playersQueue.Dequeue();
        eliminatedPlayers.Push(eliminatedPlayer);
        Console.WriteLine($"{eliminatedPlayer} is eliminated!");
    }
    string winner = playersQueue.Dequeue();
    Console.WriteLine($"The winner is {winner}!");

    // Order of elimination
    Console.WriteLine("\nOrder of elimination");
    while (eliminatedPlayers.Count > 0)
    {
        Console.WriteLine(eliminatedPlayers.Pop());
    }
}

static void Run()
{
    Console.Write("Enter number of players: ");
    int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the elimination interval: ");
    int eliminationInterval = Convert.ToInt32(Console.ReadLine());

    PlayHotPotatoGame(numberOfPlayers, eliminationInterval);
}



