/* 
 Author: Zack Slezak
 Date: 2/9/2023
 Comments: This C# Consolole application code demostrates the use 
           of Arrays through the output of a Fibonacci series
*/
using System;
namespace Deliverable4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defines the size of the array which will be the first 25 numbers
            int size = 25;

            //Creates a new array for the fibonacci series
            int [] fibonacci = new int[size];

            //Initializes the fibonacci series array, need the first two numbers
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            //For loop to generate and scale the Fibonacci Series, starting with the third (i=2) number
            for (int i = 2; i < size; i++)
            {
                //Output of each new number is the sum of the previous two numbers
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            //For loop to display the fibonacci sequence output until completion of 25 numbers
            Console.WriteLine("The Fibonacci Series is as follows: \n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}