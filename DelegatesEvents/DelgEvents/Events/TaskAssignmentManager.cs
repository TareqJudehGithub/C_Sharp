namespace Events
{
    internal class TaskAssignmentManager
    {
        #region Delegates
        internal delegate void TaskAssignedEventHandler(object sender, OfficeTask task);
        #endregion
        #region Events
        internal event TaskAssignedEventHandler TaskAssigned;
        #endregion

        #region Methods
        protected virtual void OnTaskAssigned(OfficeTask task)
        {
            TaskAssigned?.Invoke(this, task);
        }
        #endregion

        internal void AssignTask(string taskName)
        {
            OfficeTask newTask = new OfficeTask(taskName);
            OnTaskAssigned(newTask);
        }

    }
}
