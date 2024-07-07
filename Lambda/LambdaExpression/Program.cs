// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lambda Expressions\n");

void GreetUser() => Console.WriteLine("Hello World!");


GreetUser();

Func<int> addition = (x, y) => x + y;
