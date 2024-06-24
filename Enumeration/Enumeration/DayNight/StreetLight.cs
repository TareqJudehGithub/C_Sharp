namespace DayNight
{
    internal enum LightMode
    {
        Day,
        Night
    }
    internal class StreetLight
    {
        private LightMode currentMode;

        internal StreetLight()
        {
            currentMode = LightMode.Day;
        }

        internal void ChangeLight()
        {
            switch (currentMode)
            {
                case LightMode.Night:
                    currentMode = LightMode.Day;
                    break;
                case LightMode.Day:
                    currentMode = LightMode.Night;
                    break;
            }
        }
        internal void ShowLight()
        {
            Console.WriteLine($"Curren Light is {currentMode}");
        }
    }
}