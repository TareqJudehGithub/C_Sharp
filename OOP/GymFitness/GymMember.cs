namespace GymFitness
{
    internal abstract class GymMember
    {
        internal string Name { get; set; }
        internal int Age { get; set; }

        internal GymMember(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #region Methods
        public abstract void DisplayMembershipDetails();
        #endregion
    }
}

