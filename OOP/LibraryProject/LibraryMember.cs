namespace LibraryProject
{
    internal abstract class LibraryMember
    {
        #region Properties
        internal string MemberName { get; set; }
        internal int Age { get; set; }
        internal int YearJoined { get; set; }

        #endregion

        #region Constructors
        protected LibraryMember(string name, int age, int yearJoined)
        {
            MemberName = name;
            Age = age;
            YearJoined = yearJoined;
        }
        #endregion

        #region Methods

        internal abstract void DisplayMemberDetails();
        #endregion
    }
}
