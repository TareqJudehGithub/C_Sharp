using TraficLights;

internal class Program
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();


        for (int i = 0; i < 5; i++)
        {
            trafficLight.DisplayColor();

            Console.Write("Press Enter button to change the traffic light color: ");
            Console.ReadLine();

            trafficLight.ChangeColor();

        }

    }
}