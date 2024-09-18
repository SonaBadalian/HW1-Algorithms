using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //1.Print all elements of the list.
        List<int> integerList = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        Console.WriteLine("Elements of the list:");
        foreach (int number in integerList)
        {
            Console.WriteLine(number);
        }

        ////2.From a three-digit number (e.g., 124), print the largest digit.

        //        int number = 124;

        //        int hundreds = number / 100;
        //        int decs = (number / 10) % 10;
        //        int units = number % 10;

        //        int largestDigit = Math.Max(hundreds, Math.Max(decs, units));

        //        Console.WriteLine($"Largest digit in {number}: {largestDigit}");


        ////3.From a three-digit number (e.g., 124), print the smallest digit.
        //        int number = 124;

        //        int hundreds = number / 100;
        //        int decs = (number / 10) % 10;
        //        int units = number % 10;

        //        int smallestDigit = Math.Min(hundreds, Math.Min(decs, units));

        //        Console.WriteLine($"Smallest digit in {number}: {smallestDigit}");



        ////4.From an array, find all even values and print their sum.
        //        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //        int sumEven = 0;
        //        foreach (int number in numbers)
        //        {
        //            if (number % 2 == 0)
        //            {
        //                sumEven += number;
        //            }
        //        }
        //        Console.WriteLine($"Sum of all even values: {sumEven}");


        ////5.Calculate and print the average of all elements in the array.
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //int sum = 0;
        //foreach (int number in numbers)
        //{
        //    sum += number;
        //}

        //double average = (double)sum / numbers.Length;

        //Console.WriteLine($"Average of all elements: {average}");


    }
}






