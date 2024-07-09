namespace FlightSystem
{
    internal class Flight
    {
        #region Properties
        internal string FlightNumber { get; set; }
        internal string DepartureCity { get; set; }
        internal string ArrivalCity { get; set; }

        internal DateTime DepartureTime { get; set; }
        internal DateTime ArrivalTime { get; set; }
        #endregion

        #region Methods
        public override string ToString() => $"{FlightNumber} - {DepartureCity} to {ArrivalCity}\nDeparture: {DepartureTime}\nArrival: {ArrivalCity}";
        #endregion
    }
}
