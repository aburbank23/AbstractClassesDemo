using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        //to make defaults -> do the = and beyond it ab
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        //"stubbed out" ab
        public abstract void DriveAbstract();

        //must have implementation "{}" if virtual ab
        //classes inheriting from this class can choose to override "virtual" ab
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
