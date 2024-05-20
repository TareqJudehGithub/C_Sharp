// See https://aka.ms/new-console-template for more information
Console.WriteLine("DateTime class\n");


DateTime interPizzaDay23 = new DateTime(year: 2024, month: 5, day: 18);

Console.WriteLine($"The year is: {interPizzaDay23.Year}");
Console.WriteLine($"The month is: {interPizzaDay23.Month}");
Console.WriteLine($"The day is: {interPizzaDay23.Day}");
Console.WriteLine($"Day of the week: {interPizzaDay23.DayOfWeek}");  // Saturday
Console.WriteLine($"Pizza year is: {interPizzaDay23.Year}");
Console.WriteLine("");

// Adding 1 year to the current year object above
DateTime nextYear = interPizzaDay23.AddYears(1);
Console.WriteLine($"Next year is: {nextYear.Year}");

