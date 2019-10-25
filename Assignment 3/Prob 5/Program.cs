/*
Author: Cody Martin 
Date:   10/25/2019
CTEC 135
​
Module 4: Programming Assignment 3, Problem 5
 Create a class with two fields, one a string and the other an int. 
 The class implements the IComparable interface.
 Create appropriate methods for the class
 Objects in the class should be ordered in the following manner:
 primary sort order is alphabetical according to the text field
 secondary sort order is largest first according to the int field
 Demonstrate the the objects can be sorted according to requirement
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating Animal class objects to sort

            Animal ani1 = new Animal("B", 2);
            Animal ani2 = new Animal("A", 1);
            Animal ani3 = new Animal("C", 1);
            Animal ani4 = new Animal("B", 1);
            Animal ani5 = new Animal("B", 2);
            Animal ani6 = new Animal("B", 3);

            Console.WriteLine(ani1.CompareTo(ani2));
            Console.WriteLine();

            // insert the objects into an array
            Animal[] aniArray = new Animal[6];
            aniArray[0] = ani1;
            aniArray[1] = ani2;
            aniArray[2] = ani3;
            aniArray[3] = ani4;
            aniArray[4] = ani5;
            aniArray[5] = ani6;

            //sorting 
            Array.Sort(aniArray);

            //print!
            foreach (Animal element in aniArray)
                Console.WriteLine(element);


                
        }
    }
}
