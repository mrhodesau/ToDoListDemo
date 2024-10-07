public class ToDoList
{
  private List<string> tasks;

  public ToDoList()
  {
    // Create a new list of strings for tasks
    tasks = new List<string>();
  }

  public void AddTask(string task)
  {
    // Add the task to the list
    tasks.Add(task);
    Console.WriteLine($"Task added: {task}");
  }

  public void RemoveTask(string task)
  {
    // Remove the task from the list if it exists
    if (tasks.Remove(task))
    {
      Console.WriteLine($"Task removed: {task}");
    }
    else
    {
      Console.WriteLine($"Task not found: {task}");
    }
  }

  public string ViewTasks()
  {
    // Join the task(s) to display on the console if there are any
    return tasks.Count == 0 ? "No tasks available." : $"[{string.Join(", ", tasks)}]";
  }
}
