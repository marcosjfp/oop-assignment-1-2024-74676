using System;
using RentalCar;
namespace RentalCar;
public class RentalCarDriver
{
    public static void Main(string[] args)
    {
        // Create four RentalCar objects using different constructors
        RentalCar car1 = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, false);
        RentalCar car2 = new RentalCar("Ford", "Focus", "HatchBack", "XYZ456", 40.00);
        RentalCar car3 = new RentalCar("BMW", "Z4", "Convertible", "43A13", 38.00, true);
        RentalCar car4 = new RentalCar("Tesla", "Model X", "CrossOver", "EV789", 120.00, true);

        // Display each car's details
        car1.Display();
        car2.Display();
        car3.Display();
        car4.Display();

        // Call methods for testing purposes
        //Console.WriteLine("Testing Borrow Method on car1:");
        //car1.Borrow();  // Should borrow the car
        //car1.Borrow();  // Should show an error message
        //car1.ReturnRentalCar();  // Should return the car
        //car1.Borrow();  // Should now borrow again

        //Console.WriteLine("\nTesting ChangePrice and CheckPrice on car2:");
        //car2.ChangePrice(45.00);  // Changing price to 45
        //Console.WriteLine($"New price of {car2.Model}: {car2.CheckPrice():C}");

        //Console.WriteLine("\nChecking Borrowed status of car3:");
        //Console.WriteLine($"{car3.Model} borrowed status: {car3.CheckBorrowed()}");

        //Console.WriteLine("\nReturning car4:");
        //car4.ReturnRentalCar();  // Returning a borrowed car
        //car4.Borrow();           // Borrow it again to check status

        //Keep the console window open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
