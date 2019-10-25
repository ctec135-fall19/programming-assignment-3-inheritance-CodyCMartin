using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_5
{
    class Animal : IComparable
    {

        // fields

        private string name;
        private int age;

        // properties to access the private members
        public string Name
        {
            get {return  name;}
            set {name = value;}
        }

        public int Age
        {
            get {return age;}
            set {age = value;}
        }

        // Constructor to class
        public Animal(string str, int x)
        {
            this.age = x;
            this.name = str;
        }


        //interface method created 

        public int CompareTo(object obj)
        {
            // cast object to Animal class type
            Animal ani = obj as Animal;

            // if cast is successful make comparisons
            if (ani != null)
            {
                // return value of comparison 
                if (string.Compare(this.Name, ani.Name) < 0) return -1;
                if (string.Compare(this.Name, ani.Name) > 0) return -1;
                // if strings are the same, compare the ints (Age)
                else
                {
                    if (this.Age < ani.Age) return -1;
                    if (this.Age > ani.Age) return 1;
                    else return 0;
                }

            }
            else
                throw new ArgumentException("Not a Animal Object");

        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }





            
       

        

    }
}
