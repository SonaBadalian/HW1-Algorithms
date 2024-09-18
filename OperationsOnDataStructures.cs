
using System;
using System.Collections.Generic;
using System.Linq;  

class Program
{
    static void Main()
    {
        // 1.Calculate and print the sum of all elements in the list
        List<int> integerList = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        int sum = integerList.Sum();
        Console.WriteLine($"Sum = {sum}");


        //// 2.Calculate and print the sum of all values in the dictionary.
        //Dictionary<string, int> dictionary = new Dictionary<string, int>
        //{
        //    { "Deca", 10 },
        //    { "Hecto", 100 },
        //    { "Kilo", 1000 },
        //    { "Mega", 1000000 },
        //};
        //int sum = dictionary.Values.Sum();

        //Console.WriteLine($"Sum of all values in the dictionary: {sum}");



        //// 3.Remove 2 elements from the queue and print the remaining elements.
        //Queue<int> integerQueue = new Queue<int>(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34});

        //integerQueue.Dequeue();
        //integerQueue.Dequeue(); 

        //Console.WriteLine("Remaining elements in the queue:");
        //foreach (int number in integerQueue)
        //{
        //    Console.WriteLine(number);
        //}


        //// 4.Remove 2 elements from the stack and print the remaining elements.
        //Stack<int> integerStack = new Stack<int>(new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 });
        //integerStack.Pop(); 
        //integerStack.Pop(); 

        //Console.WriteLine("Remaining elements in the stack:");
        //foreach (int number in integerStack)
        //{
        //    Console.WriteLine(number);
        //}




    }
}

