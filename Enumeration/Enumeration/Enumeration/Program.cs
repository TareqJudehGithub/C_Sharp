internal class Program
{
    static void Main(string[] args)
    {
        Season winter = Season.Winter;
        Console.WriteLine($"The cold season is cold: {winter}");
        Console.WriteLine($"{nameof(winter)} is data type of {winter.GetType().Name}\n");

        // return winter int value
        int winterInt = Convert.ToInt32(winter);
        Console.WriteLine($"winter numeric value = {winterInt}\n");

        DayOfWeek dayOfWeek = new DayOfWeek();
        dayOfWeek.FindDayOFTheWeek();
        Console.WriteLine();
    }
    enum Season
    {
        // Enum manual value assignment
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4
    }
}
internal class DayOfWeek
{
    Day today = new Day();
    Day Todayis = Day.Monday;
    internal enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    internal void FindDayOFTheWeek()
    {
        Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Day todayIs = Day.Monday;

        // Convert enum to int value
        int zero = (int)Day.Monday;
        int one = Convert.ToInt32(Day.Tuesday);
        int two = (int)Day.Wednesday;
        int three = Convert.ToInt32(Day.Thursday);
        int four = Convert.ToInt32(Day.Friday);
        int five = Convert.ToInt32(Day.Saturday);
        int six = Convert.ToInt32(Day.Sunday);

        switch (userInput)
        {
            case 0:
                todayIs = Day.Monday;
                break;
            case 1:
                todayIs = Day.Tuesday;
                break;
            case 2:
                todayIs = Day.Wednesday;
                break;
            case 3:
                todayIs = Day.Thursday;
                break;
            case 4:
                todayIs = Day.Friday;
                break;
            case 5:
                todayIs = Day.Saturday;
                break;
            case 6:
                todayIs = Day.Sunday;
                break;

        }
        Console.WriteLine($"Today is {todayIs}");

    }
}