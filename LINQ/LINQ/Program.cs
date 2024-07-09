// See https://aka.ms/new-console-template for more information
Console.WriteLine("LINQ\n");

// A list of numbers
List<int> numbers = [1, 14, 3, 6, 4, 9, 11, 16, 2, 5];

var evenNumber = from num in numbers
                 where num % 2 == 0
                 select num;

Console.WriteLine(evenNumber);
