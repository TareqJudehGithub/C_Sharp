using GymFitness;

internal class Program
{
    static void Main(string[] args)
    {
        // Objects
        PremiumMembers premiumMembers = new PremiumMembers("John Smith", 27);
        premiumMembers.DisplayMembershipDetails();
    }
}