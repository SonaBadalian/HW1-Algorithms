using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // 1.Create a list of integers and add 5 elements to it.
        List<int> integerList = new List<int>();

        integerList.Add(5);
        integerList.Add(4);
        integerList.Add(3);
        integerList.Add(2);
        integerList.Add(1);

        foreach (int number in integerList)
        {
            Console.WriteLine(number);
        }


        // 2.Create a dictionary with string keys and integer values, and add 5 key-value pairs to it.
        //Dictionary<string, int> dictionary = new Dictionary<string, int>();

        //dictionary.Add("Un", 1);
        //dictionary.Add("Deux", 2);
        //dictionary.Add("Trois", 3);
        //dictionary.Add("Quatre", 4);
        //dictionary.Add("Cinq", 5);

        //foreach (var kvp in dictionary)
        //{
        //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //}


        // 3.Create a queue of integers and add 5 elements to it.
        //Queue<int> integerQueue = new Queue<int>();

        //integerQueue.Enqueue(1);
        //integerQueue.Enqueue(10);
        //integerQueue.Enqueue(100);
        //integerQueue.Enqueue(1000);
        //integerQueue.Enqueue(10000);

        //while (integerQueue.Count > 0)
        //{
        //    Console.WriteLine(integerQueue.Dequeue());
        //}

        // 4.Create a stack of integers and add 5 elements to it.
        //Stack<int> integerStack = new Stack<int>();

        //integerStack.Push(1);
        //integerStack.Push(1);
        //integerStack.Push(2);
        //integerStack.Push(3);
        //integerStack.Push(5);

        //while (integerStack.Count > 0)
        //{
        //    Console.WriteLine(integerStack.Pop());
        //}



    }
}

