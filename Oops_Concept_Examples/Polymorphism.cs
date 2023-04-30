using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    /*
    
    Method Overloading is the common way of implementing polymorphism.
    It is the ability to redefine a function in more than one form.
    A user can implement function overloading by defining two or more functions in a class sharing the same name.

    Different ways of doing overloading methods- 
     Method overloading can be done by changing:  

    1] The number of parameters in two methods.
    2] The data types of the parameters of methods.
    3] The Order of the parameters of methods.

    */


     

 
    


    class MethodOverloading
    {

        // 1] The number of parameters in two methods.

        // 

        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }




        // 2] The data types of the parameters of methods.
        // overloading by changing the Data types of the parameters

       
        // adding three double values.
        public double Add(double a,
                          double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }




        // 3] The Order of the parameters of methods.
        // overloading by changing the order of the parameters

        // Method
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
        }

        // Method
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "+ "Id2 : " + id);
        }



        //
        //when method signature is same and the return type is different
        //The compiler will give error as the return value alone is not sufficient for the compiler to figure out which function it has to call.
        //Only if both methods have different parameter types (so, they have the different signature), then Method overloading is possible.

        // adding two integer value.
        /*
        public int Add(int a, int b)
        {

            int sum = a + b;
            return sum;
        }

        // adding three integer value.
        public double Add(int a, int b)
        {
            double sum = a + b + 0.0;
            return sum;
        }
        */

    }


}
