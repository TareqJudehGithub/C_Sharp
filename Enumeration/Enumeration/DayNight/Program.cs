using DayNight;

internal class Program
{
    static void Main(string[] args)
    {
        // Objects
        StreetLight light = new StreetLight();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Press any key to change light: ");
            Console.ReadLine();
            light.ChangeLight();
            light.ShowLight();
        }
    }
}
