namespace PersonInfoMngSys
{
    internal class Person
    {
        #region Fields
        private string _name;
        private int _age;
        private string _address;
        private string _position;
        private string _department;
        #endregion

        #region Constructors

        #endregion

        #region Properties
        internal string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }
        internal int Age
        {
            set
            {
                this._age = value;
            }
            get { return this._age; }
        }
        internal string Address
        {
            set { this._address = value; }
            get { return this._address; }
        }
        internal string Position
        {
            set { this._position = value; }
            get { return this._position; }
        }
        internal string Department
        {
            set { this._department = value; }
            get { return this._department; }
        }
        #endregion

        #region Methods
        internal void DisplayPersonInfo()
        {
            Console.WriteLine("\nPerson Information: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Adrress: {Address}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Department: {Department}");
        }
        #endregion
    }
}
