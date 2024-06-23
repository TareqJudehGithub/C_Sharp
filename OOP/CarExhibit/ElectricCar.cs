namespace CarExhibit
{
    internal class ElectricCar : Car
    {
        internal ElectricCar(string model, int year) : base(model: model, year: year) { }

        #region Methods
        internal override void DisplayInfo()
        {
            Console.WriteLine($"Electric Car - Model: {Model}, Year: {Year}");
        }
        protected override void StartEngine()
        {
            Console.WriteLine("Starting electric motor!");
        }
        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating silently at {speed} mph!");
        }
        #endregion
    }
}
