namespace Employee
{
    internal class Search
    {
        internal void SearchEmp(Employees employee)
        {
            int employeeId = employee.EmpID;
            string employeeName = employee.EmpName;
            Dictionary<int, string> employeesRec = employee.EmployeesRecords;

            string userInput = string.Empty;
            string userAnswer = string.Empty;

            do
            {

                Console.Write("Enter name: ");
                userInput = Console.ReadLine();

                if (employeesRec.ContainsValue(userInput))
                {
                    Console.WriteLine($"{employeeName} ID is {employeeId}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
                Console.Write("Search more employees? (y/n) ");
                userAnswer = Console.ReadLine().ToLower();
            }
            while (userAnswer.Equals("y"));
        }
    }
}
