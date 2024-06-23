namespace CarExhibit
{
    internal class Car
    {
        #region Properties
        internal string Model { get; set; }
        internal int Year { get; set; }
        #endregion

        #region Constructors
        internal Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        #endregion

        #region Methods
        internal virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}");
        }

        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine Started!");
        }
        #endregion
        protected virtual void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating at {speed} mph");
        }
        internal void OperateVihecle(int speed)
        {
            StartEngine();
            Accelerate(speed);
        }
    }
}
