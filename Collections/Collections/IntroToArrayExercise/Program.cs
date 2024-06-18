class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduction to Arrays - Exercise\n");

        Console.Write("Enter total scores number: ");
        int scoresTotal = Convert.ToInt32(Console.ReadLine());
        int[] scores = new int[scoresTotal];

        EnterScores(scores: scores);
        int sum = FindSum(scores: scores);

        double averageScore = FindAverage(sum: sum, scores: scores);

        Console.WriteLine($"\nAverage score = {averageScore}");
    }

    // Methods
    static void EnterScores(int[] scores)
    {
        int score = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write("Enter a score: ");
            score = Convert.ToInt32(Console.ReadLine());
            scores[i] = score;
        }
        Console.WriteLine("\nElements in scores:");
        foreach (int elem in scores)
        {
            Console.WriteLine(elem);
        }
    }
    static int FindSum(int[] scores)
    {
        int sum = 0;

        foreach (int score in scores)
        {
            sum += score;
        }
        return sum;
    }
    static double FindAverage(int sum, int[] scores)
    {
        double averageScore = sum / scores.Length;
        return averageScore;

    }
}
