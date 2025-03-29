
# Stacks

A stack can be thought of like a stack of plates or pancakes. Just as you place one plate on top of another, you can push items (such as variables or functions) onto a stack. The key idea is that the last item placed on the stack is the first one to be removed. This is known as the Last In, First Out (LIFO) principle.

Stacks allow us to backtrack or redo. We do this all the time when wrighting a word document. You can give a try by pressing ( crl + z ). 


## Methods

There are severel methods that allow us use a stack. We'll go over how what a stack looks like and how **Push, Pop, Peek, and Count** affect stacks.

![image](Images/stack.png) 
<!--- Reference 
https://www.stratascratch.com/blog/commonly-asked-data-structure-interview-questions/ --->  


### Push
When creating a stack we need to specify the type of data we will be storing such as an int or string. In the example below we will store integers.

To **`Push(value)`** to a stack is to add to the stack. Everytime we push an element we are `"stacking"` that element onto the prievious. To add to a stack is as simple as calling the stack dot push with the value.

```Csharp
Stack<int> values = new Stack<int>();

// Add elements to Stack
values.Push(10);
values.Push(20);
values.Push(30);
values.Push(40);
```

### Pop

To Remove, we call the stack then `Pop()`. Remeber there is an order to a stack. For something to be removed we need to remove from the top or the last. Remeber `LIFO`, Last In First Out. This can hinder us from accessing anything at the bottom but the benefit of stacks are to remeber where we've been. If we remove from the stack we created before.

```Csharp
// Remove 3 elements from Stack
values.Pop(); // Popped 40
values.Pop(); // Popped 30
values.Pop(); // Popped 20
```
We can to `console.write(values.Pop())`, to see the value we removed.

### Peek

What if we want to view the top element without removing it from the stack? That's why we have `Peek()`. Below is an example of how to use peek.

```Csharp
values.Push(30);
values.Push(40);

// If we want to look at the last element without removing we use Peek
Console.WriteLine(values.Peek()); // Output = 40
```

### Count

We can also check the size of our stack. We don't want to cause and `underflow` by removing when the stack is empty or an `overflow` by adding to many elemnets to a stack. Checking the size of the stack is done by calling the property `Count()`.

```Csharp
values.Push(10);
values.Push(20);
values.Push(30);
values.Push(40);

// Check the length of current Stack
var length = values.Count();
Console.WriteLine(length); // Output = 4

// Remove 3 elements from Stack
values.Pop();
values.Pop();
values.Pop();

// Check the new Length
length = values.Count();
Console.WriteLine(length); // Output = 1
```

## Big O notation

A stack can be represented using an array of various data types. Because stack is a common data structure, the framework comes with a built-in Stack class. These methods are shown in the table below, along with the big O performance of them.

|   Method    |     Description    |  Performace  |
|:------------|:------------------:|-------------:|
| Push(value) | Add values to the stack|     O(1)     |
|    Pop()    | Remove values from stack  |     O(1)     |
|   Count()    | Gets the size of the Stack  |     O(1)     |
|   Peek()   | Looks at the Last or Top element of the Stack | O(1) |



## Example Problem: Task Manager

Lets say we have a set of task that need to be completed, and to help us stay focused we create a stack so we can only complete one at a time. 

Task Manager Requirements:
- Allow user to add a task
- To Remove a task when completed
- To view next task
- To view all task that is left
- Display Results 

You can go here to see how a stack can be used to solve this problem: [Example Problem](Stacks/stacks_example_problem/Program.cs)


## Problem to Solve: Reverse Words

We want to provide a word then have it spelled backwards. For example apple spelled backwards is elppa. Use a stack to provide a code that can do this.

Go here to work out the problem: [Problem](Stacks/stacks_problem/Program.cs)

You can compare your code with the solution here: [Solution](Stacks/stacks_solution/Solution.cs)

[Back to Welcome Page](0-welcome.md)