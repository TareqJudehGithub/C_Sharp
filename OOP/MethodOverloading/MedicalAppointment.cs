namespace MethodOverloading
{
    internal class MedicalAppointment
    {
        #region Fields
        private string _patientName;
        private DateTime _date;
        #endregion

        #region Constructors
        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        #endregion

        #region 
        public void ShowInfo()
        {
            Console.WriteLine($"Patient: {_patientName},  Date: {_date}");
        }
        public void Reschedule(DateTime date)
        {
            _date = date;
        }
        public void Reschedule(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }

        #endregion
    }

}


