using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Base
    {

        public string firstName { set; get; }

        // method to be called by child
        public virtual void PrintBase(string hi)
        {
            Console.WriteLine(hi);
        }

        // method to be overriden by child 
        public virtual void PrintOverride()
        {
        }

        public virtual void method()
        {
            Console.WriteLine("I am from the Base method");
        }

        public string GetName()
        {
            return this.firstName;
        }
        
    }
}
