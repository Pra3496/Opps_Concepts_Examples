using static Oops_Concept_Examples.TestOverride;

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
                Console.WriteLine("2  : Interface");
                Console.WriteLine("3  : Encapsulation");
                Console.WriteLine("4  : Abstraction with abstract class");
                Console.WriteLine("5  : Abstraction with Interface");
                Console.WriteLine("6  : Polymorphism with Method Overloading");
                Console.WriteLine("7  : Polymorphism with Method Overriding");
                Console.WriteLine("8  : Refrences");
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
                    case 3:
                        Console.WriteLine("\n-------{ Encapsulation }--------");


                        BankAccount myAccount = new BankAccount(1000);

                        myAccount.Deposit(500);
                        Console.WriteLine("Balance: "+ myAccount.GetBalance());

                        myAccount.Withdraw(1200);
                        Console.WriteLine("Balance: "+ myAccount.GetBalance());



                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n-------{ Abstraction with Abstract Class }--------");

                        // creating reference of Shape class
                        // which refer to Square class instance
                        Shape sh = new Square(4);

                        // calling the method
                        double result = sh.area();

                        Console.WriteLine("{0}", result);




                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\n-------{ Abstraction with Interface }--------");

                        // creating an instance of Bicycle 
                        // doing some operations 
                        Bicycle bicycle = new Bicycle();
                        bicycle.changeGear();
                        bicycle.speedUp();
                        bicycle.applyBrakes();

                        Console.WriteLine("Bicycle present state :");
                        bicycle.printStates();

                        // creating instance of bike.
                        Bike bike = new Bike();
                        bike.changeGear();
                        bike.speedUp();
                        bike.applyBrakes();

                        Console.WriteLine("Bike present state :");
                        bike.printStates();



                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\n-------{ Polymorphism with Method Overloading }--------");

                        MethodOverloading methodOverloading = new MethodOverloading();

                        Console.WriteLine("\noverloading by changing the Number of parameters\n");
                        int sum1 = methodOverloading.Add(1, 2);
                        Console.WriteLine("sum of the two " + "integer value : " + sum1);

                        int sum2 = methodOverloading.Add(1, 2, 3);
                        Console.WriteLine("sum of the three "+ "integer value : " + sum2);


                        Console.WriteLine("\nOverloading by changing the Data types of the parameters\n");

                        double sum3 = methodOverloading.Add(1.0, 2.0, 3.0);
                        Console.WriteLine("sum of the three " + "double value : " + sum3);

                        Console.WriteLine("\nOverloading by changing the order of the parameters\n");

                        methodOverloading.Identity("Pranav",25);

                        methodOverloading.Identity(25,"Pranav");

                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine("\n-------{ Polymorphism Method overriding }--------");


                        var employee1 = new SalesEmployee("Pranav", 1000, 500);
                        var employee2 = new Employee("piyush", 1200);

                        Console.WriteLine("Employee1 {0} earned: {1}",employee1.Name, employee1.CalculatePay());
                        Console.WriteLine("Employee2 {0} earned: {1}", employee2.Name, employee2.CalculatePay());


                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\n-------{ Refrances }--------");

                        int Number = 0;

                        int i = 0; //use ref to pass the parameter by reference 

                        Console.WriteLine("Table of 2");
                        while ( i < 10)
                        {
                            Refrances.ProcessNumber(ref Number);

                            Console.WriteLine(Number);

                            i++;
                        }


                        Console.Write("Press any key....");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("\n-------{ Constructor and Types }--------");
                        
                        MyConstructor defaultConstructor = new MyConstructor();

                        MyConstructor parameteriezedConstructor = new MyConstructor("pranav",121,9736111);

                        ConstructorTwo model = new ConstructorTwo("1999",34);

                        ConstructorTwo copyConstructor = new ConstructorTwo(model);


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