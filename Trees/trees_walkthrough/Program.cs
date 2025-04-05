
using System;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

// This code was initially setup by ChatGBT with only insert and inorder
// The rest of the code is made by Jeremy Sanders


// Node class representing each element in the BST 
class Node
{
    public int Data; // Value entered
    public Node Left, Right; // Pointers \
    
    public Node(int data) // Node Contsrutor
    {
        Data = data;
        Left = Right = null!;
    }
}

// Binary Search Tree class
class BinarySearchTree
{
    public Node Tree; // Node object
        
    public BinarySearchTree() // Tree Constructor 
    {
        Tree = null!; // Initalize to null 
    }

    // Insert a new node into the BST 
    public void Insert(int data)
    {
        Tree = InsertRec(Tree, data); // Reference 
    }
    private Node InsertRec(Node root, int data) 
    {   // Base case
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data == root.Data || data < root.Data)  
            root.Left = InsertRec(root.Left, data); // If value is the less set to the left
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data); // If value is greater set to the right

        return root;
    }

    // Inorder traversal (Left, Root, Right) 
    public void Inorder()
    {
        InorderRec(Tree);
        Console.WriteLine();
    }
    private void InorderRec(Node root) 
    {
        if (root != null)           
        {
            InorderRec(root.Left);          
            Console.Write(root.Data + " ");
            InorderRec(root.Right);
        }
    }




    // List to store left values of 50
    private List<int> allValues = new List<int>();
    // Set Root
    public void Balance() 
    {
        allValues.Clear();                   // Step 1: Empty the list
        BalanceRec(Tree);              // Step 2: Fill it with inorder traversal
        

        Tree = RebuildBalancedTree(allValues, 0, allValues.Count - 1); // Step 3: Rebuild
        Console.WriteLine($"Balanced root is {Tree.Data}");
    }
    private void BalanceRec(Node root)
    {                
        if (root == null) return;

        BalanceRec(root.Left);
        allValues.Add(root.Data);
        BalanceRec(root.Right);
    }
    private Node RebuildBalancedTree(List<int> sorted, int start, int end)
    {
        if (start > end) return null;

        int mid = (start + end) / 2;
        Node node = new Node(sorted[mid]);  

        node.Left = RebuildBalancedTree(sorted, start, mid - 1);
        node.Right = RebuildBalancedTree(sorted, mid + 1, end);

        return node;
    }



    // Search for value
    public void Contains(int data) 
    {
        Console.WriteLine($"{ContainsRec(Tree, data)} has been found");
    }
    private int ContainsRec(Node node, int data)
    {
        if (node.Data == data){
            return node.Data;
        }

        if (node != null){
            if (node.Data != data && data < node.Data) {
                ContainsRec(node.Left, data);
            }
            else {
                ContainsRec(node.Right, data);
            }
        }
        return data;
    }


    // The height of tree
    public void Height()
    {
        HeightRec(Tree);
        Console.WriteLine(HeightRec(Tree));
    }
    private int HeightRec(Node node)
    {
        // Start with 1 to include _root
        int heightL = 0;
        int heightR = 0;    

        if (node.Left != null){
            heightL = 1 + HeightRec(node.Left); 
        }
        
        if (node.Right != null){
            heightR = 1 + HeightRec(node.Right);
        }
        
        if (heightL >= heightR)
            return heightL;
        else 
            return heightR;
    }   

    // Remove a value
    public void Remove(int data) {
        Tree = RemoveRec(Tree, data);
        
    }
    private Node RemoveRec(Node root, int data) {

        // Base case
        if (root == null) {                     
            return null; 
        }
        
        // Data is less than go left
        if (data < root.Data) {
            root.Left = RemoveRec(root.Left, data); 

        // Data is greater go right
        } else if (data > root.Data) {
            root.Right = RemoveRec(root.Right, data);

        // Found value
        } else {
            // No leaves or both are null
            if (root.Left == null && root.Right == null){
                return null;
            }

            // Left is null so return right
            if (root.Left == null)
                return root.Right;
            // Right is null so return left
            else if (root.Right == null)
                return root.Left;

            
        // Merge Left and Right
        // This is how we reshape our subtrees
        Node leftSubtree = root.Left;
        Node rightSubtree = root.Right;

        // Find where to attach the right subtree in left subtree
        Node attachPoint = leftSubtree;
        while (attachPoint.Right != null)
            attachPoint = attachPoint.Right;

        attachPoint.Right = rightSubtree;

        return leftSubtree;
        }

        return root;
    }
}



// Example usage
class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(30); 
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        // The tree will look something like this
        //          50
        //         /  \
        //       30    70
        //      / \    / \
        //    30  40  60  80
        //   /
        //  20
        
        // Display tree in order
        Console.WriteLine("Inorder traversal of the BST:");
        bst.Inorder();

        // Display height
        Console.WriteLine(); 
        bst.Height(); 

        // Remove a value then display new tree
        Console.WriteLine();
        bst.Remove(50);
        bst.Remove(70);
        bst.Inorder();
    }
}

