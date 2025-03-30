
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        LinkedList<string> playList = new LinkedList<string>();

        Console.WriteLine("Hello Welcome to Your Music Playlist");


        var choice = -1;
        while (choice != 0){
            Console.WriteLine();
            Console.WriteLine($"To add a song select 1");
            Console.WriteLine($"To remove a song select 2");
            Console.WriteLine($"To view playlist select 3");
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

                // Here we can add a song to the playlist
                case 1:
                    // Node for song
                    Console.WriteLine("Title of song: ");
                    string titleOfSong = Console.ReadLine()!;

                    int placement = -1;
                    
                    // Select placement of song
                    Console.WriteLine("To add at the beginn select 1.");
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
                        playList.AddFirst(titleOfSong);
                        Console.WriteLine("Song added");

                    } else if (placement == 2) {
                        // Add in the center
                        foreach (var title in playList) {
                            Console.WriteLine(title);
                        }

                        // Add new song after song in playlist
                        Console.WriteLine("\nEnter the title of the song you would like to place the new song after: ");
                        var song = Console.ReadLine();

                        if (string.IsNullOrEmpty(song))
                        {
                            Console.WriteLine("Song to place after cannot be empty.");
                            break;
                        }

                        var songNode = playList.Find(song!);
                        
                        if (song != null) {
                            playList.AddAfter(songNode!, titleOfSong);
                            Console.WriteLine("Your new song has been added");
                        } else {
                            Console.WriteLine("Song not in playlist");
                            break;
                        }
                    } else {
                        playList.AddLast(titleOfSong);
                        Console.WriteLine("Song added");
                    }
                    break;

                // Here we can remove the most recent task added
                case 2:
                    Console.WriteLine("\nEnter the title of the song you would like to remove: ");
                    var songRemove = Console.ReadLine();

                    if (string.IsNullOrEmpty(songRemove))
                    {
                        Console.WriteLine("Song title cannot be empty.");
                        break;
                    }

                    var songNodeRemove = playList.Find(songRemove!);

                    if (songRemove != null){
                        playList.Remove(songNodeRemove!);
                        Console.WriteLine($"{songRemove} has been removed from task.");
                    }
                    else {
                        Console.WriteLine("Song not in playlist");
                    }
                    break;

                // Here we can look at the most recent task
                case 3:
                    foreach (var song in playList){
                        Console.WriteLine($"{song}");
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Please select a choice 1 - 4");
                    break;
            }
        }  
    }
}