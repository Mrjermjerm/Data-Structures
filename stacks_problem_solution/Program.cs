
using System;
using System.Collections;
using Microsoft.VisualBasic;


class Program
{
    static void Main()
    {
        Stack<char> stackOfLetters = new Stack<char>();
        string word = "apple";

        foreach (var letter in word){
            stackOfLetters.Push(letter);
        }
        
        Console.Write($"{word} spelled backwards is ");

        foreach (var letters in word){
            var letter = stackOfLetters.Pop();
            Console.Write(letter);
        }
    }
}