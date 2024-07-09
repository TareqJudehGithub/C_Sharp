namespace CarSystem
{
    internal class Car
    {
        #region Fields/Properties     
        internal static protected int counter = 0;
        internal int CarId { get; set; }

        internal string CarModel { get; set; }
        internal string CarMake { get; set; }
        internal int CarYear { get; set; }
        internal string CarColor { get; set; }
        #endregion

        #region Constructors
        internal Car()
        {
            counter++;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"\nID: {CarId}\nModel: {CarModel}\nManufacturer: {CarMake}\nYear: {CarYear}\nColor: {CarColor}\n";
        }
        #endregion
    }
}
