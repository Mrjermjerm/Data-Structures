
using System;
using System.Collections;
using Microsoft.VisualBasic;


class Program
{
    static void Main()
    {
        // Create a Stack that can hold our task
        Stack<string> tasks = new Stack<string>();

        // Diplay options based on user choice
        int choice = -1;        

        while (choice != 0){
            Console.WriteLine();
            Console.WriteLine($"To add a task select 1");
            Console.WriteLine($"To remove a task select 2");
            Console.WriteLine($"To view next task select 3");
            Console.WriteLine($"To view all task select 4");
            Console.WriteLine($"To quit 0");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)){
                Console.WriteLine("Invalid input! Please enter a number between 0 - 4.");
                continue; 
            }

            switch (choice)
            {   
                // Leave when finished
                case 0:
                    Console.WriteLine("Goodbye");
                    break;

                // Here we can add a task to the stack
                case 1:
                    Console.WriteLine("Name the task: ");
                    string task = Console.ReadLine();
                    tasks.Push(task);
                    break;

                // Here we can remove the most recent task added
                case 2:
                    if (tasks.Count() > 0){
                        string removed = tasks.Pop();
                        Console.WriteLine($"{removed} has been removed from task.");
                    }
                    else {
                        Console.WriteLine("No tasks to remove.");
                    }
                    break;

                // Here we can look at the most recent task
                case 3:
                    var next = tasks.Peek();
                    Console.WriteLine($"{next} is next on tasks to do.");
                    break;

                // Here we can display every task that was added to the stack
                case 4:
                    if (tasks.Count() == 0){
                        Console.WriteLine("No tasks available.");
                        continue;
                    } else{
                        Console.WriteLine("Tasks:");
                        foreach (var item in tasks)
                        {
                            Console.WriteLine("- " + item);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Please select a choice 1 - 4");
                    break;
            }
        } 
    }
}