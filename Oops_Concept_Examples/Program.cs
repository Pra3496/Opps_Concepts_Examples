namespace Oops_Concept_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            Random random = new Random();

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("\nWelcome to OOPS Concept Prgrams\n");
                Console.WriteLine("Please enter option given below\n");
                Console.WriteLine("1  : Class And Methods");
                Console.WriteLine("0  : EXIT");
                Console.WriteLine("\n===========================================\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                //Switch case to call different method 
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n-------{ Class And Methods }--------");
                        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
                        Console.WriteLine(tuffy.ToString());
                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n-------{ Inheritance }--------");

                        // single inheritance
                        Dogs dog = new Dogs();
                        dog.Eat();
                        dog.Bark();

                        // multi-level inheritance
                        Horse horse = new Horse();
                        horse.Eat();
                        horse.Run();
                        horse.Gallop();

                        // hierarchical inheritance
                        Eagle eagle = new Eagle();
                        Penguin penguin = new Penguin();
                        eagle.Fly();
                        eagle.Hunt();
                        penguin.Fly();
                        penguin.Swim();

                        // multiple inheritance
                        MyClass myClass = new MyClass();
                        myClass.Method1();
                        myClass.Method2();

                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Write("Thank you For Using Application....");
                        flag = false;   
                        break;
                }
            }
        }
    }
}