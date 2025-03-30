

class Program
{
    static void Main()
    {
        // Create linked list

        // We'll start with an intro to the program
        Console.WriteLine("Train Scheduling System for the day");

        // This program has 3 main parts
        // 1st to add an event... Under addding an event we need to be able to specify where 
        // 2nd to remove an event
        // 3rd and finally we need to veiw today's schedule

        // The code is already structured. Uncomment some portions and start filling out the missing pieces
        // Good luck

        var choice = -1;
        while (choice != 0){
            
            // Add user options here

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
                    // // Provide an option for user to add in the Beginning, Center, and End
                    
                    // // To leave
                    // if () {
                        
                    //     Console.WriteLine("Exiting...");
                    //     Thread.Sleep(30000);
                    //     break;
                    // // To add in the beginning
                    // } else if () {               

                    //     Console.WriteLine("Event added");

                    // // Add in the center
                    // } else if () {

                    //     // Add new event after event in schedule
                    //     Console.WriteLine("\nEnter the event you would like to schedule the new event after: ");
                    //     var newEvent = Console.ReadLine();
                    
                    // // Add in the end
                    // } else {
                       
                    //     Console.WriteLine("event added");
                    // }
                    break;

                // Here we can remove the most recent task added
                case 2:
                    // Console.WriteLine("\nEnter the event you would like to remove: ");
                    
                    // // Event is found, remove
                    // if (){

                    //     Console.WriteLine($"{   } has been removed from task.");
                    // }
                    // // Event is not listed
                    // else {
                    //     Console.WriteLine("Event not in schedule");
                    // }
                    break;

                // Here we can look at the most recent task
                case 3:
                    // Hint
                    // Traverse through the list
                    
                    break;

                default:
                    Console.WriteLine("Please select a choice 1 - 4");
                    break;
            }
        }  
    }
}