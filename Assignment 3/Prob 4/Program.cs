/*
Author: Cody Martin 
Date:   10/20/2019
CTEC 135


Create a hierarchy of classes that demonstrates polymorphic behavior in the following situation
An array of the base class type is created and initialized with a member of each class in the hierarchy
Show that a method belonging to the base class is called from a child instance
Demonstrate overriding a base class method by a child
Demonstrate a child method calling the parent's method
Demonstrate use of "as" keyword
Demonstrate use of "is" keyword
Demonstrate calling a method in a for loop iterating over the instances in the array
Demonstrate calling a method in a foreach loop
Demonstrate switch statement that responds differently depending upon the type of the object
Create an object of "object" type, but initialized of the base class type, then cast it to the actual type so you can call a method
Create an object of the base class type but initialized to a child type that has a specialized method. Call the specialized method by using casting.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            // Array initialized with a member of each class in the hierarchy

            Base[] myArray = new Base[2];
            myArray[0] = new Base();
            myArray[1] = new Child();

            #endregion

            #region 2

            // Base method called by child class. Say hi to the child!

            Child c1 = new Child();

            Console.WriteLine(c1.GetType());
            c1.PrintBase("Hi from the child class but calling a base method!");
            Console.WriteLine();

            #endregion

            #region 3

            //Child method overriding base method

            Console.WriteLine(c1.GetType());
            c1.PrintOverride();

            #endregion

            #region 4

            // using IS keyword to check if c1 child object is of child object

            if (c1 is Child)
            {
                Console.WriteLine(c1.GetType());
                Console.WriteLine("c1 IS a child type");
            }
            else
            {
                Console.WriteLine(c1.GetType());
                Console.WriteLine("c1 is NOT a child type");
            }

            #endregion

            #region 5

            // using IS keyword to check if c1 child object is of Base object

            if (c1 is Base)
            {
                Console.WriteLine("c1 IS a base type");
            }
            else
            {
                Console.WriteLine("c1 is NOT a base type");
            }

            Console.WriteLine();

            #endregion

            #region 6

            // using AS keyword to convert c1 from child to base

            Base b1 = c1 as Child;
            if (b1 == null)
            {
                Console.WriteLine("succeeded converting from child to base: {0}", b1.GetType());

            }
            else
            {
                Console.WriteLine("failed to convert from child to base: {0}", b1.GetType());
            }

            Console.WriteLine();

            #endregion

            #region 7

            // calling a method in a for loop iterating over instances in the array


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("iterating over the array with a for loop");
            }

            Console.WriteLine();

            #endregion

            #region 8

            // Calling a method per instance in an array using foreach loop


            foreach (Base element in myArray)
            {
                element.method();
            }

            Console.WriteLine();

            #endregion

            #region 9

            //Demonstrate switch statement that responds differently depending upon the type of the object

            foreach (Base element in myArray)
            {
                switch (element)
                {
                    case Child gc:
                        Console.WriteLine("Child");
                        break;
                    case Base c:
                        Console.WriteLine("Base");
                        break;
                   
                    default:
                        Console.WriteLine("default");
                        break;

                }
            }

            #endregion

            #region 10

            //Create an object of "object" type, but initialized of the base class type, 
            //then cast it to the actual type so you can call a method
            //Create an object of the base class type but initialized to a child type 
            //that has a specialized method.Call the specialized method by using casting.

            Console.WriteLine();

            object obj = new Base();
            ((Base)obj).method();

            Base p2 = new Child();
            ((Child)p2).SpecializedMethod();
            Console.WriteLine();


            #endregion









        }    
    }
}
