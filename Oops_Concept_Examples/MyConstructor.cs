using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    public class MyConstructor
    {
        int id;
        int num;
        string name;

        // a Default constructor
        public MyConstructor()
        {
            Console.WriteLine("Constructor Called");
        }


        // parameterized constructor.
        public MyConstructor(string name, int id, int num)
        {
            this.name = name;
            this.id = id;
            this.num = num;
        }





       

    }

    public class ConstructorTwo
    {
        private string month;
        private int year;

        // declaring Copy constructor
        public ConstructorTwo(ConstructorTwo s)
        {
            month = s.month;
            year = s.year;
        }

        // Instance constructor
        public ConstructorTwo(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        // Get details of Geeks
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }


        //static constructor
        static ConstructorTwo()
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }
    }
}
