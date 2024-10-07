# ToDoListDemo

## Overview
ToDoListDemo is a simple C# application which can be run as an automated simulation or in a manual interacctive mode. There is error handling to verify user inputs to make sure task and option selctions are valid.

## Features
- Run an automated simulation of adding, removing, and viewing tasks
- Manually add, remove, and view tasks in the 

## Running
1. Clone the repository:
  ```sh
  git clone https://github.com/mrhodesau/ToDoListDemo.git
  ```
2. Navigate to the project directory:
  ```sh
  cd ToDoListDemo
  ```
3. Run in VS Code/Visual Studio

## Sample Output

### Automated Simulation
  ```sh
  Running ToDo List Program...
Enter Operating Mode:
1 - Automated simulation of the ToDo List Program
2 - Manually interact with the ToDo List Program
1
Task added: Finish report
Task added: Read a book
[Finish report, Read a book]
Task removed: Finish report
[Read a book]
Task not found: Go shopping
  ```
### Manual Interaction Sample
  ```sh
  Running ToDo List Program...
Enter Operating Mode:
1 - Automated simulation of the ToDo List Program
2 - Manually interact with the ToDo List Program
2
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
1
Enter the task you want to add:
Task 1
Task added: Task 1
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
1
Enter the task you want to add:
Task 2
Task added: Task 2
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
1
Enter the task you want to add:
Task 3
Task added: Task 3
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
2
[Task 1, Task 2, Task 3]
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
3
Enter the task you want to remove:
Task 2
Task removed: Task 2
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
2
[Task 1, Task 3]
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
1
Enter the task you want to add:
Task 4
Task added: Task 4
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
3
Enter the task you want to remove:
Task 5
Task not found: Task 5
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
2
[Task 1, Task 3, Task 4]
What would you like to do?
1 - Add a task
2 - View tasks
3 - Remove a task
4 - Exit the program
4
Exiting...
  ```