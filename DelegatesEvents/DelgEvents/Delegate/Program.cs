internal class Program
{
    internal delegate double MathOperation(double x, double y);

    static void Main(string[] args)
    {
        Console.WriteLine("Delegates\n");

        Console.Write("Enter the 1st number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the 1st number: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        // Create new delegates
        Program program = new Program();

        MathOperation addDelegate = program.Add;
        MathOperation SubtractDelegate = program.Subtract;
        MathOperation MultipleDelegate = program.Multiple;
        MathOperation DivideDelegate = program.Divide;


        // Perform operations 
        double addResult = PerformOperation(firstNum, secondNum, addDelegate);
        double subtractResult = PerformOperation(firstNum, secondNum, SubtractDelegate);
        double multipleResult = PerformOperation(firstNum, secondNum, MultipleDelegate);
        double divideResult = PerformOperation(firstNum, secondNum, DivideDelegate);

        Console.WriteLine($" Add Result:      {addResult}");
        Console.WriteLine($" Subtract Result: {subtractResult}");
        Console.WriteLine($" Multiple Result: {multipleResult}");
        Console.WriteLine($" Divide Result:   {divideResult}");
    }

    // Method - Add, Subtract, and Multiply
    internal double Add(double x, double y)
    {
        return x + y;
    }
    internal double Subtract(double x, double y)
    {
        return x - y;
    }

    internal double Multiple(double x, double y)
    {
        return x * y;
    }

    internal double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero - error :(");
            return double.NaN;
        }
    }
    static double PerformOperation(double x, double y, MathOperation operation)
    {
        return operation(x, y);
    }
}
