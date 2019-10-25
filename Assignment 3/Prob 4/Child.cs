using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Child : Base
    {     



        // override method from base
        public override void PrintOverride()
        {
            Console.WriteLine("Overriding the base from child method");
            Console.WriteLine();
        }
        public override void method()
        {
            Console.WriteLine("I am from the Child method");
        }
        public void SpecializedMethod()
        {
            Console.WriteLine("SpecializedMethod");
        }
    }
}
