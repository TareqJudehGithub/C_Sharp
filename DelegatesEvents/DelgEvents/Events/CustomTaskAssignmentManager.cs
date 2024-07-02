namespace Events
{
    internal class CustomTaskAssignmentManager : TaskAssignmentManager
    {
        protected override void OnTaskAssigned(OfficeTask task)
        {
            Console.WriteLine("Custom logic before task assignment");
            base.OnTaskAssigned(task);
            Console.WriteLine("Custom logic after task assignment");
        }
        private void CustomTaskHandler(object sender, OfficeTask task)
        {
            Console.WriteLine($"New task assigned: {task.TaskName}");
        }
        public CustomTaskAssignmentManager()
        {
            TaskAssigned += CustomTaskHandler;
        }
    }
}
