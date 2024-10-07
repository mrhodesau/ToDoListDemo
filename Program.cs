class Program
{
  // Define constants to avoid using magic values in the code

  // Consts for the different modes of operation
  const string RunAutomatedSimulation = "1";
  const string RunManualInteraction = "2";

  // Consts for the different actions in manual interaction mode
  const string AddTask = "1";
  const string ViewTasks = "2";
  const string RemoveTask = "3";
  const string ExitProgram = "4";

  static void Main(string[] args)
  {
    ToDoList todo = new ToDoList();

    Console.WriteLine("Running ToDo List Program...");

    // Ask user which mode they want to run
    Console.WriteLine("Enter Operating Mode:");
    Console.WriteLine("1 - Automated simulation of the ToDo List Program");
    Console.WriteLine("2 - Manually interact with the ToDo List Program");

    // Read input data from the console (verify that the input is not null)
    string ModeSelection = Console.ReadLine() ?? string.Empty;

    if (ModeSelection == RunAutomatedSimulation)
    {
      // Run the automated simulation
      AutomatedSimulation(todo);
    }
    else if (ModeSelection == RunManualInteraction)
    {
      // Run the manual interaction until the user chooses to exit
      while (true)
      {
        string SelectedAction = ManualInteraction(todo);

        if (SelectedAction == ExitProgram)
        {
          // Exit the loop/program
          break;
        }
      }
    }
    else
    {
      Console.WriteLine("Invalid mode selection.");
    }
  }

  // Automated simulation of the ToDo List Program
  static void AutomatedSimulation(ToDoList todo)
  {
    // Add tasks
    todo.AddTask("Finish report");
    todo.AddTask("Read a book");

    // View tasks
    Console.WriteLine(todo.ViewTasks()); // Output: ["Finish report", "Read a book"]

    // Remove a task
    todo.RemoveTask("Finish report");

    // View tasks again
    Console.WriteLine(todo.ViewTasks()); // Output: ["Read a book"]

    // Try removing a task that doesn't exist
    todo.RemoveTask("Go shopping");
  }

  // Manually interact with the ToDo List Program
  static string ManualInteraction(ToDoList todo)
  {
    // Ask the user what action they would like to perform
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1 - Add a task");
    Console.WriteLine("2 - View tasks");
    Console.WriteLine("3 - Remove a task");
    Console.WriteLine("4 - Exit the program");

    // Read input data from the console (and handle if null)
    string OperationSelection = Console.ReadLine() ?? string.Empty;

    if (OperationSelection == AddTask)
    {
      Console.WriteLine("Enter the task you want to add:");

      // Read the task from the console and only use it if it's not null
      string Task = Console.ReadLine() ?? string.Empty;

      if (!string.IsNullOrEmpty(Task))
      {
        todo.AddTask(Task);
      }
      else
      {
        Console.WriteLine("Task cannot be empty.");
      }
    }
    else if (OperationSelection == ViewTasks)
    {
      // Display the current tasks
      Console.WriteLine(todo.ViewTasks());
    }
    else if (OperationSelection == RemoveTask)
    {
      Console.WriteLine("Enter the task you want to remove:");

      // Read the task from the console and only use it if it's not null
      string Task = Console.ReadLine() ?? string.Empty;
      
      if (!string.IsNullOrEmpty(Task))
      {
        todo.RemoveTask(Task);
      }
      else
      {
        Console.WriteLine("Task cannot be empty.");
      }
    }
    else if (OperationSelection == ExitProgram)
    {
      // We are exiting the program
      Console.WriteLine("Exiting...");
    }
    else
    {
      Console.WriteLine("Invalid operation selection.");
    }

    return OperationSelection;
  }
}
