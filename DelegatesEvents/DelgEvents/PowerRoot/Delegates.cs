namespace PowerRoot
{
    internal class Delegates
    {
        internal delegate double MathOperation(double x, double y);
        static double PerformOperation(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }

        internal void ShowResult()
        {
            MathOperation powerDelegate = Operations.Power;
            MathOperation rootDelegate = Operations.Root;

            double powerResult = PerformOperation(x: Operations.FirstValue, y: Operations.SecondValue, operation: powerDelegate);
            double rootResult = PerformOperation(x: Operations.FirstValue, y: Operations.SecondValue, operation: rootDelegate);

            Console.WriteLine($"{Operations.FirstValue} to the power of {Operations.SecondValue} = {powerResult}");
            Console.WriteLine($"Square root of {Operations.FirstValue} = {rootResult}");
        }
    }
}

