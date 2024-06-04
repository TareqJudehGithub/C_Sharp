namespace SumCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };

            int sum = 0;
            bool shallAddPositiveOnly = true;

            // Objects
            Calculator calculator = shallAddPositiveOnly ? new PositiveCalculator() : new Calculator();
            sum = calculator.CalculateSum(myNumbers);
            Console.WriteLine($"Sum is = {sum}");
        }
    }
}

