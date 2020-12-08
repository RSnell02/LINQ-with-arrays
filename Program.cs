/*
 * Project: LINQWithArrays
 * Filename: Program.cs
 * Author: R. Snell
 * Date: Dec. 08, 2020
 * Purpose: To demonstrate the syntax and use of LINQ (Language Integrated 
 *          Query) with simple objects, in this case arrays.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An integer array
            var values = new[] { 1, 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            // Display the original values
            foreach (var element in values)
                Console.Write($" {element}");
            Console.WriteLine();

            // LINQ query that obtains values greater than 4 from the array
            var filtered =
                from value in values    // Data source
                where value > 4
                select value;
            // Display the filtered results
            Console.Write("Array values greater than 4:");
            foreach (var element in filtered)
                Console.Write($" {element}");
            Console.WriteLine();

            // Sort the original values in ascending order
            var sorted =
                from value in values
                orderby value
                select value;
            // Display the sorted results
            Console.WriteLine("Original array, sorted:");
            foreach (var element in sorted)
                Console.Write($" {element}");
            Console.WriteLine();

            // Sort the filtered results in descending order
            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;
            // Display the sorted results
            Console.WriteLine("Value > 4, in descending order:");
            foreach (var element in sortFilteredResults)
                Console.Write($" {element}");
            Console.WriteLine();

            // Filter the original array and sort results in
            // descending order
            var sortAndFilter =
                from value in values
                where value > 4
                orderby value descending
                select value;
            // Display the sorted results
            Console.WriteLine("Values > 4, sorted from original:");
            foreach (var element in sortAndFilter)
                Console.Write($" {element}");
            Console.WriteLine();
        }   // end Main()
    }   // end class
}   // end namespace
