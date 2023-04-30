using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    /*
     * 
     * A class is a user-defined blueprint or prototype from which objects are created.
     * Basically, a class combines the fields and methods(member function which defines actions) into a single unit
     * 
    */
    public class Dog
    {
        // Instance Variables
        string name;
        string breed;
        int age;
        string color;

        // Constructor Declaration of Class
        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        // Property 1
        public String GetName()
        {
            return name;
        }

        // Property 2
        public String GetBreed()
        {
            return breed;
        }

        // Property 3
        public int GetAge()
        {
            return age;
        }

        // Property 4
        public String GetColor()
        {
            return color;
        }

        // Method 1
        public String ToString()
        {
            return ("Hi my name is " + this.GetName()
                    + ".\nMy breed, age and color are " + this.GetBreed()
                    + ", " + this.GetAge() + ", " + this.GetColor());
        }
    }
}
