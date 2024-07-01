
using PowerRoot;

internal class Program
{
    static void Main(string[] args)
    {
        // Objects
        Delegates delegates = new Delegates();


        Console.Write("Enter the first value: ");
        Operations.FirstValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second value: ");
        Operations.SecondValue = Convert.ToDouble(Console.ReadLine());

        delegates.ShowResult();

    }
}