using System;


namespace Oops_Concept_Examples
{
    /*
    
    Like a class, Interface can have methods, properties, events, and indexers as its members. But interfaces will contain only the declaration of the members. 
    The implementation of the interface’s members will be given by class who implements the interface implicitly or explicitly.

    */


    // interface declaration
    public interface Vehicle
    {
        // Property signatures:
        int speed { get; set; }

        int gear { get; set; }

       

        // all are the abstract methods.
        void changeGear();
        void speedUp();
        void applyBrakes();

        
    }

    // class implements interface
   public class Bicycle : Vehicle
    {

        public int speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 0 && value < 100)
                    speed = value;
                else
                    Console.WriteLine("not allowed");
            }
        }

        public int gear
        {
            get
            {
                return gear;
            }
            set
            {
                if (value > 0 && value < 6)
                    gear = value;
                else
                    Console.WriteLine("not allowed");
            }
        }


      



        // to change gear
        public void changeGear()
        {

            gear++;
        }

        // to increase speed
        public void speedUp()
        {

            speed++;
        }

        // to decrease speed
        public void applyBrakes()
        {

            speed = 0;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +" gear: " + gear);
        }
    }

    // class implements interface
    class Bike : Vehicle
    {

        public int speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 0 && value < 220)
                    speed = value;
                else
                    Console.WriteLine("not allowed");
            }
        }

        public int gear
        {
            get
            {
                return gear;
            }
            set
            {
                if (value > 0 && value < 6)
                    gear = value;
                else
                    Console.WriteLine("not allowed");
            }
        }

        // to change gear
        public void changeGear()
        {

            gear++;
        }

        // to increase speed
        public void speedUp()
        {

            speed++;
        }

        // to decrease speed
        public void applyBrakes()
        {

            speed = 0;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +" gear: " + gear);
        }

    }
}
