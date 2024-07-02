using Events;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Events and Event Handlers\n");

        CustomTaskAssignmentManager customTaskManager = new CustomTaskAssignmentManager();
        customTaskManager.AssignTask("Complete project report");


    }
}