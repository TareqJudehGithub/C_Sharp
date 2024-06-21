namespace Employee
{
    internal class Employees
    {
        #region Fields
        string answer = string.Empty;
        private int _empID;
        private string _empName;
        #endregion

        #region Properties
        internal int EmpID
        {
            set { this._empID = value; }
            get { return this._empID; }
        }
        internal string EmpName
        {
            set { this._empName = value; }
            get { return this._empName; }
        }
        internal Dictionary<int, string> EmployeesRecords = new Dictionary<int, string>();

        #endregion

        #region Methods
        internal Dictionary<int, string> AddEmployee()
        {
            do
            {
                Console.Write("Employee ID: ");
                EmpID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Employee Name: ");
                EmpName = Console.ReadLine();

                EmployeesRecords.Add(EmpID, EmpName);
                Console.Clear();

                Console.WriteLine($"{EmpName} has been successfully added.");
                Console.Write("Add more employess? (y/n)");
                answer = Console.ReadLine().ToLower();
                Console.Clear();
            }
            while (answer.Equals("y"));


            return EmployeesRecords;
        }
        internal void ShowEmployees()
        {
            foreach (var emp in EmployeesRecords)
            {
                Console.WriteLine(emp);
            }

        }
        #endregion
    }
}
