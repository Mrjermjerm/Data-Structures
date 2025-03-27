
using System.Runtime.InteropServices.Marshalling;

class Node
{

}


class Program
{
    static void Main()
    {
        // List called linkedList
        LinkedList<int> linkedList = new LinkedList<int>();

        // We can create a node. This way in the future when we search or modify the linked list 
        // we can search by the node and not the value 
        LinkedListNode<int> secondNode = linkedList.AddFirst(2);

        // Or we can add at the head this way
        linkedList.AddFirst(1); 
        
        // To add at the tail
        linkedList.AddLast(4);
        LinkedListNode<int>sixthNode = linkedList.AddLast(6);

        // To insert in the center
        linkedList.AddAfter(secondNode, 3);
        linkedList.AddBefore(sixthNode, 5);

       foreach (int num in linkedList)
        {
            Console.Write(num + " -> ");
        }
        Console.WriteLine("null");

        // To Rmove 
        linkedList.RemoveFirst();
        linkedList.RemoveLast();
        linkedList.Remove(secondNode);

        foreach (int num in linkedList)
        {
            Console.Write(num + " -> ");
        }
        Console.WriteLine("null");  
        
        // To find a value
        var found = linkedList.Find(4);
        // To print the value that we found 
        Console.WriteLine(found?.Value);
    }
}