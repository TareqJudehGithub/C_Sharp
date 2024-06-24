namespace TraficLights
{
    internal enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }
    internal class TrafficLight
    {
        private TrafficLightColor currentColor;

        internal TrafficLight()
        {
            // Set currentColor to a default color - red. 
            currentColor = TrafficLightColor.Red;
        }

        internal void ChangeColor()
        {
            switch (currentColor)
            {
                case TrafficLightColor.Red:
                    currentColor = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Yellow:
                    currentColor = TrafficLightColor.Red;
                    break;
                case TrafficLightColor.Green:
                    currentColor = TrafficLightColor.Yellow;
                    break;
            }
        }
        internal void DisplayColor()
        {
            Console.WriteLine($"Traffic light is currently {currentColor}");
        }

    }

}
