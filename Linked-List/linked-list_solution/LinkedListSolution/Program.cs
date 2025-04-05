

using System;
using System.Collections;
using Microsoft.VisualBasic;



class Program
{
    static void Main()
    {
        // Create linked list
        LinkedList<string> trainSchedule = new LinkedList<string>();

        Console.WriteLine("Train Scheduling System for the day");


        var choice = -1;
        while (choice != 0){
            Console.WriteLine();
            Console.WriteLine($"To add an event select 1");
            Console.WriteLine($"To remove a event select 2");
            Console.WriteLine($"To view today's schedule select 3");
            Console.WriteLine($"To quit 0");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)){
                Console.WriteLine("Invalid input! Please enter a number between 0 - 3.");
                continue; 
            }

            switch (choice)
            {   
                // Leave when finished
                case 0:
                    Console.WriteLine("Goodbye");
                    break;

                // Here we can add a new event
                case 1:
                    // Node for event
                    Console.WriteLine("Train Schedule: ");
                    string time = Console.ReadLine()!;

                    int placement = -1;
                    
                    // Select placement of train arriving or departing
                    Console.WriteLine("To add at the beging select 1.");
                    Console.WriteLine("To add in between select 2.");
                    Console.WriteLine("To add at the end select 3.");
                    Console.WriteLine($"To quit 0");

                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out placement)){
                        Console.WriteLine("Invalid input! Please enter a number between 0 - 4.");
                        continue; 
                    }
                    
                        // Quit
                    if (placement == 0) {
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(30000);
                        break;

                    } else if (placement == 1) {
                        // Add in front
                        trainSchedule.AddFirst(time);
                        Console.WriteLine("Event added");

                    } else if (placement == 2) {
                        // Add in the center
                        foreach (var _event in trainSchedule) {
                            Console.WriteLine(_event);
                        }

                        // Add new event after event in schedule
                        Console.WriteLine("\nEnter the event you would like to schedule the new event after: ");
                        var newEvent = Console.ReadLine();

                        if (string.IsNullOrEmpty(newEvent))
                        {
                            Console.WriteLine("Event to place after cannot be empty.");
                            break;
                        }

                        var eventNode = trainSchedule.Find(newEvent!);
                        
                        if (newEvent != null) {
                            trainSchedule.AddAfter(eventNode!, time);
                            Console.WriteLine("Your new event has been added");
                        } else {
                            Console.WriteLine("Event not in schedule");
                            break;
                        }
                    } else {
                        trainSchedule.AddLast(time);
                        Console.WriteLine("event added");
                    }
                    break;

                // Here we can remove the most recent task added
                case 2:
                    Console.WriteLine("\nEnter the event you would like to remove: ");
                    var eventRemove = Console.ReadLine();

                    if (string.IsNullOrEmpty(eventRemove))
                    {
                        Console.WriteLine("Event cannot be empty.");
                        break;
                    }

                    var eventNodeRemove = trainSchedule.Find(eventRemove!);

                    if (eventRemove != null){
                        trainSchedule.Remove(eventNodeRemove!);
                        Console.WriteLine($"{eventRemove} has been removed from task.");
                    }
                    else {
                        Console.WriteLine("Event not in schedule");
                    }
                    break;

                // Here we can look at the most recent task
                case 3:
                    foreach (var todaysEvent in trainSchedule){
                        Console.WriteLine($"{todaysEvent}");
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Please select a choice 1 - 3");
                    break;
            }
        }  
    }
}