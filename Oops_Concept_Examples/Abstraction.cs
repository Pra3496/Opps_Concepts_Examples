using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    /*

     Data Abstraction may also be defined as the process of identifying only the required characteristics of an object ignoring the irrelevant details.
     The properties and behaviors of an object differentiate it from other objects of similar type and also help in classifying/grouping the objects.
    */

    // abstract class
    abstract class Shape
    {

        // abstract method
        public abstract int area();
    }

    // square class inheriting
    // the Shape class
    class Square : Shape
    {

        // private data member
        private int side;

        // method of  square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
}
