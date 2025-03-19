

class Program
{
    static void Main()
    {
       // Create a stack named values
        Stack<int> values = new Stack<int>();

        // Add elements to Stack
        values.Push(10);
        values.Push(20);
        values.Push(30);
        values.Push(40);

        // If we want to look at the last element without removing we use Peek
        Console.WriteLine(values.Peek()); // Output = 40

        // Spacing
        Console.WriteLine(); 

        // Check the length of current Stack
        var length = values.Count();
        Console.WriteLine(length); // Output = 4

        // Spacing
        Console.WriteLine(); 

        // Remove 3 elements from Stack
        values.Pop(); // Popped 40
        values.Pop(); // Popped 30
        values.Pop(); // Popped 20

        // Spacing
        Console.WriteLine(); 

        // Check the new Length
        length = values.Count();
        Console.WriteLine(length); // Output = 1
    }
}