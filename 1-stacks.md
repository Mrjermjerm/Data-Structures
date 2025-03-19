
# Stacks

A stack can be thought of like a stack of plates or pancakes. Just as you place one plate on top of another, you can push items (such as variables or functions) onto a stack. The key idea is that the last item placed on the stack is the first one to be removed. This is known as the Last In, First Out (LIFO) principle.

Stacks allow us to backtrack or redo. We do this all the time when wrighting a word document. You can give a try by pressing ( crl + z ). 



## Push and Pop

To <b>`Push`</b> to a stack is to add and to <b>`Pop`</b> from a stack is to remove from a stack. Remeber there is an order to a stack. When we add to, we are `"stacking"` whatever we're adding. For something to be removed we need to remove from the top or the last. Remeber `LIFO`, Last In First Out. This can hinder us from accessing anything at the bottom but the benefit of stacks are to remeber where we've been. 

![image](Images/stack.png) 
<!--- Reference 
https://www.stratascratch.com/blog/commonly-asked-data-structure-interview-questions/ --->  

If we wanted to create a stack of integers we simply create a new stack then start pushing to that stack. 

### Push

```csharp
Stack<int> values = new Stack<int>();

values.Push(1);
values.Push(2);
values.Push(3);
values.Push(4);
```
To Remove, we call the stack then Pop.

### Pop

```csharp
values.Pop();
values.Pop();
values.Pop();
values.Pop();
```
If we were to `console.write()` after every element we just popped, our output would be `4 3 2 1`; Last In First Out.

## Length

We can also check the size of our stack. We don't want to cause and `underflow` by removing when the stack is empty or an `overflow` by adding to many elemnets to a stack. Checking the size of the stack is done by calling the property `.Count`.

```Csharp
// Create a stack named values
Stack<int> values = new Stack<int>();

// Add elements to Stack
values.Push(1);
values.Push(2);
values.Push(3);
values.Push(4);

// Check the length of current Stack
var length = values.Count();
Console.WriteLine(length); // Output = 4

// Remove elements from Stack
values.Pop();
values.Pop();
values.Pop();

// Check the new Length
length = values.Count();
Console.WriteLine(length); // Output = 1
```
## Peek

What if we want to view the top element without removing it from the stack? That's why we have `Peek()`. Below is an example of how to use peek.

```Csharp
// Add elements onto Stack
values.Push(1);
values.Push(2);
values.Push(3);

Console.WriteLine(values.Peek());
// Output is 3
```

## Big O notation

A stack can be represented using an array of various data types. Because stack is a common data structure, the framework comes with a built-in Stack class. These methods are shown in the table below, along with the big O performance of them.

|   Method    |    Code            |  Performace  |
|:------------|:------------------:|-------------:|
| push(value) | myStack.Push(value)|     O(1)     |
|    pop()    |    myStack.Pop()   |     O(1)     |
|   size()    |   myStack.Count()  |     O(1)     |


## Example: Task Manager

Lets say we have a set of task that need to be completed, and to help us stay focused we create a stack so can only complete one at a time. 

Task Manager Requirements:
- Allow user to add a task
- To Remove a task when completed
- To view next task
- To view all task that is left
- Display Results 

```Csharp
Stack<string> tasks = new Stack<string>();
var choice = -1;

while (choice != 0){
    Console.WriteLine();
    Console.WriteLine($"To add a task select 1");
    Console.WriteLine($"To remove a task select 2");
    Console.WriteLine($"To view next task select 3");
    Console.WriteLine($"To view all task select 4");
    Console.WriteLine($"To quit 0");
    Console.Write("Enter your choice: ");

    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 - 4.");
        continue;
    }

    switch (choice)
    {
        case 0:
            Console.WriteLine("Goodbye");
            break;

        case 1:
            Console.WriteLine("Name the task: ");
            string task = Console.ReadLine();
            tasks.Push(task);
            break;

        case 2:
            if (tasks.Count > 0){
                string removed = tasks.Pop();
                Console.WriteLine($"{removed} has been removed from task.");
            }
            else {
                Console.WriteLine("No tasks to remove.");
            }
            break;

        case 3:
            var next = tasks.Peek();
            Console.WriteLine($"{next} is next on tasks to do.");
            break;

        case 4:
            if (tasks.Count == 0){
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
```

Note that we have to check if the stack is empty to avoid Underflow. 

## Problem to Solve: Reverse Words

Lets say we have a word that we want to spell backwords. We take the word then add each letter to a stack, after which we then pop each letter we just added to the stack.

Copy the following code then solve. We will use apple and the result should be elppa. 

```Csharp
class Program
{
    static void Main()
    {
        Stack<char> stackOfLetters = new Stack<char>();
        string word = "apple";

        // Insert your code here

        // Remove this comment and uncomment the next line to test
        // Console.Write($"{word} spelled backwards is ");
    }
}
```

You can check your code with the solution here: [Solution](stacks_problem_solution)

[Back to Welcome Page](0-welcome.md)