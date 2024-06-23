namespace CarExhibit
{
    internal class SportsCar : Car
    {
        internal SportsCar(string model, int year) : base(model: model, year: year) { }

        #region Methods
        internal override void DisplayInfo()
        {
            Console.WriteLine($"Sports Car - Model: {Model}, Year: {Year}");
        }
        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Performing a high-speed acceleration at {speed} mph");
        }
        #endregion
    }
}
