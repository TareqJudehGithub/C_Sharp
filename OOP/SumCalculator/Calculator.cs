namespace SumCalculator
{
    internal class Calculator
    {
        protected virtual bool IsPositive(int num)
        {
            return true;
        }
        public virtual int CalculateSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (IsPositive(num))
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}

