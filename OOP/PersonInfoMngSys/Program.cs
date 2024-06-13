namespace PersonInfoMngSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter name: ");
            string name = person.Name = Console.ReadLine();

            int age;
            bool isAgeCorrect = false;
            do
            {
                Console.Write("Enter age: ");
                isAgeCorrect = Int32.TryParse(Console.ReadLine(), out age);

                if (isAgeCorrect && age > 0)
                {
                    person.Age = age;
                    isAgeCorrect = true;
                }
                else
                {
                    Console.WriteLine("Bad age entry.");
                }

            }
            while (isAgeCorrect = false || age <= 0);
            Console.WriteLine(age);

            //person.Age = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine(person.Age);

            Console.Write("Enter address: ");
            string address = person.Address = Console.ReadLine();

            Console.Write("Enter Position: ");
            string position = person.Position = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = person.Department = Console.ReadLine();

            person.DisplayPersonInfo();
        }
    }

}
