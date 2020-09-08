using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ~Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * ~Create an abstract class called Vehicle
             * ~The vehicle class shall have three string properties Year, Make, and Model
             * ~Set the defaults to something generic in the Vehicle class
             * ~Vehicle shall have an abstract method called DriveAbstract with no implementation
             * ~Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * ~Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * ~Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * ~Provide the implementations for the (drive)abstract methods
             * ~Only in the Motorcycle class will you override the virtual drive method
            */

            // ~Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * ~Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * ~- new it up as one of each derived class
             * ~Set the properties with object initializer syntax
             */
            Car mazda = new Car() { HasTrunk = true, Make = "Mazda", Model = "3", Year = 2014 };
            Motorcycle indian = new Motorcycle() { HasSideCart = false, Make = "Indian", Model = "Scout", Year = 2020 };
            Vehicle sedan = new Car() { Make = "Subaru", Model = "Forrester", Year = 2016 }; //if there is default to property, no need to type it.
            Vehicle honda = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2014 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(mazda);
            vehicles.Add(indian);
            vehicles.Add(sedan);
            vehicles.Add(honda);

            foreach (var vcle in vehicles)
            {
                Console.WriteLine($" Make: {vcle.Make} Model: {vcle.Model} Year: {vcle.Year}");
                vcle.DriveAbstract();
                vcle.DriveVirtual();
                Console.WriteLine($"-----------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
