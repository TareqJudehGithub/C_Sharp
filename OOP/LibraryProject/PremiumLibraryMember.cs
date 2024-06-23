namespace LibraryProject
{
    internal class PremiumLibraryMember : LibraryMember
    {
        internal PremiumLibraryMember(string name, int age, int yearJoined) : base(name, age, yearJoined) { }
        internal override void DisplayMemberDetails()
        {
            Console.WriteLine($"\nName:{MemberName}\nAge: {Age}\nMember since: {YearJoined}\n");
        }
    }
}
