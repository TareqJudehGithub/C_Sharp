using LibraryProject;

internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("Name: ");
        string memberName = Console.ReadLine();

        bool isAgeInt = false;
        bool isYearInt = false;
        int memberAge = 0;
        int yearJoined = 0;

        do
        {
            Console.Write("Age: ");
            isAgeInt = int.TryParse(Console.ReadLine(), out memberAge);

            Console.Write("Member since: ");
            isYearInt = int.TryParse(Console.ReadLine(), out yearJoined);
        }
        while (!isAgeInt || !isYearInt);

        PremiumLibraryMember member = new PremiumLibraryMember(name: memberName, age: memberAge, yearJoined: yearJoined);

        member.DisplayMemberDetails();
    }
}