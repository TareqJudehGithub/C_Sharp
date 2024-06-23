namespace GymFitness
{
    internal class PremiumMembers : GymMember, IGymMembership
    {
        internal PremiumMembers(string name, int age) : base(name: name, age: age) { }

        public override void DisplayMembershipDetails()
        {
            Console.WriteLine($"Premium Members: Name {Name}, Age: {Age}.");
            Console.WriteLine("Full Access");
            Console.WriteLine("PT sessions");
            Console.WriteLine("Specialized Classes Included.");
        }

    }
}
