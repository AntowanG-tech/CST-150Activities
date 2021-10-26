using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Antowan's code - find the errors!
namespace CST_150Activity10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
            

        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                elements.Sort();                 //sorts the elements of a Set to make them easier for the user to read.
                return true;
            }

            
        }
        /* I was getting a warning on line 40 that was saying the code was "unreachable." 
         * Honestly, unless I set the breakpoint on a method in the Program.cs, nothing would populate in the console window.
         * I ended up going line by line and commenting out the statemens until something happened. Turns out the "else return false;" statement
         * stopped the loop from processing further as it would break the loop. 
         * Once that line was commented out, the loop continued pass the first element
         * 
         * While the Set class runs the if statement, if the element does not match, it will exit the if and loop again. It will do that for the 
         * entire Set until the loop finds a matching val. If no val(s) match, then the method will return false and there are no values that match.
         */
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //else
                   // return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set setA, Set setB)             //modified to take parameters for both sets. The intention is to combine the two.
        {
            Set unifiedSet = new Set();                  //creates a new List that will hold the values of both sets with no duplicates

            for (int i = 0; i < setA.elements.Count; i++)    //loop adds elements from Set A to the unifiedSet
            {
                unifiedSet.addElement(setA.elements[i]);
                
            }

            for (int j = 0; j < setB.elements.Count; j++)   //loop adds elements from Set B to the unifiedSet
            {
                unifiedSet.addElement(setB.elements[j]);
            }

            unifiedSet.elements.Sort();                 //Sorts the elements in the unifiedSet for easier readability

            return unifiedSet;
        }
    }
}
