using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    /*
     Inheritance is a fundamental concept in object-oriented programming that allows us to define a new class based on an existing class.
     The new class inherits the properties and methods of the existing class and can also add new properties and methods of its own. 
     Inheritance promotes code reuse, simplifies code maintenance, and improves code organization.

    In C#, there are 4 types of inheritance.

    */

    // single inheritance
    // Single inheritance: A derived class that inherits from only one base class.
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dogs : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dogs is barking.");
        }
    }

    //-----------------------------------------------------------------------






    // multi-level inheritance
    //Multi-level inheritance: A derived class that inherits from a base class and the derived class itself becomes the base class for another derived class.
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running.");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }

    //-----------------------------------------------------------------------



    // hierarchical inheritance
    // Hierarchical inheritance: A base class that serves as a parent class for two or more derived classes.
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }


    //-----------------------------------------------------------------------

    // multiple inheritance
    // Multiple inheritance: A derived class that inherits from two or more base classes.
    interface I1
    {
        void Method1();
    }

    interface I2
    {
        void Method2();
    }

    class MyClass : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called.");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 is called.");
        }
    }

}

