namespace SumCalculator
{
    internal class PositiveCalculator : Calculator
    {
        protected override bool IsPositive(int num)
        {
            return num > 0;
        }
    }
}
