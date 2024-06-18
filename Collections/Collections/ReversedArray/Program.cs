Console.WriteLine("Reversed Array - Exercise\n");


int[] numbers = [1, 2, 3, 4, 5,];

// Output array items - orignal state
Console.WriteLine("Original Array order of items:\n");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == numbers[^1])
    {
        Console.Write(numbers[i]);
    }
    else
    {
        Console.Write($"{numbers[i]}, ");
    }
}

// Reverse the Array items
Array.Reverse(numbers);
Console.WriteLine("\nReversed array order of items:");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == numbers[^1])
    {
        Console.Write(numbers[i]);
    }
    else
    {
        Console.Write($"{numbers[i]}, ");
    }
}

Console.ReadKey();


