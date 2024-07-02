namespace Events
{
    internal class OfficeTask
    {
        #region Properties
        internal string TaskName { get; }
        #endregion

        #region Constructors
        internal OfficeTask(string taskName)
        {
            TaskName = taskName;
        }
        #endregion

    }
}
