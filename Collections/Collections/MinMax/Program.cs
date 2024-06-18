// See https://aka.ms/new-console-template for more information
Console.WriteLine("Minimum and maximum numbers in an Array - Exercise\n");

int[] temp = [35, -5, 10, 20, -4, 24, -12];

Console.WriteLine($"Min number = {FindMinNumber(temp)}");
Console.WriteLine($"Max number = {FindMaxNumber(temp)}");

// Methods
int FindMinNumber(int[] numbers)
{
    int minNum = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minNum)
        {
            minNum = numbers[i];
        }
    }
    return minNum;
}
int FindMaxNumber(int[] numbers)
{
    int maxNum = numbers[0]; ;

    for (int i = 0; i < numbers.Length; i++)
    {

        if (numbers[i] > maxNum)
        {
            maxNum = numbers[i];
        }
    }
    return maxNum;
}