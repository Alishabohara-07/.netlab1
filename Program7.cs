using System;

// Parent class
class Vehicle
{
    // Virtual method that can be overridden in a child class
    public virtual void StartEngine()
    {
        Console.WriteLine("Starting the vehicle engine...");
    }
}

// Child class 1
class Car : Vehicle
{
    // Overriding the StartEngine method
    public override void StartEngine()
    {
        Console.WriteLine("Starting the car engine...");
    }
}

// Child class 2
class Truck : Vehicle
{
    // Overriding the StartEngine method
    public override void StartEngine()
    {
        Console.WriteLine("Starting the truck engine with a loud roar...");
    }
}

// Child class 3
class Motorcycle : Vehicle
{
    // Overriding the StartEngine method
    public override void StartEngine()
    {
        Console.WriteLine("Starting the motorcycle engine with a rev...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a parent class reference and child class objects
        Vehicle myVehicle;   // Base class reference

        myVehicle = new Car();
        myVehicle.StartEngine();  // Outputs: Starting the car engine...

        myVehicle = new Truck();
        myVehicle.StartEngine();  // Outputs: Starting the truck engine with a loud roar...

        myVehicle = new Motorcycle();
        myVehicle.StartEngine();  // Outputs: Starting the motorcycle engine with a rev...

        Console.ReadLine();
    }
}
