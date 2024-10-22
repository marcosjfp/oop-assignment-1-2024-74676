namespace RentalCar
{
    using System;

    // Abstract class and interfaces definitions
    public abstract class Vehicle
    {
        public abstract void Display();
    }

    public interface IPriceable
    {
        double CheckPrice();
        void ChangePrice(double price);
    }

    public interface IBorrowable
    {
        void Borrow();
        void ReturnRentalCar();
        bool CheckBorrowed();
    }

    // RentalCar class definition
    public class RentalCar : Vehicle, IPriceable, IBorrowable
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public string BodyType { get; private set; }
        public string RegistrationNumber { get; private set; }
        public double Price { get; private set; }
        public bool Borrowed { get; private set; }

        // Main constructor with 6 parameters
        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = ValidateBodyType(bodyType);
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        // Constructor with 5 parameters (defaults borrowed to false)
        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = ValidateBodyType(bodyType);
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = false;
        }

        // Constructor with 3 parameters (defaults borrowed to false and registrationNumber to empty string)
        public RentalCar(string manufacturer, string model, string bodyType)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = ValidateBodyType(bodyType);
            RegistrationNumber = "Unknown";  // Default value
            Price = 0.0;  // Default price
            Borrowed = false;
        }

        // Validates body type for predefined values
        private string ValidateBodyType(string bodyType)
        {
            string[] validBodyTypes = { "Saloon", "HatchBack", "Convertible", "CrossOver", "MPV" };
            if (Array.Exists(validBodyTypes, type => type.Equals(bodyType, StringComparison.OrdinalIgnoreCase)))
            {
                return bodyType;
            }
            else
            {
                throw new ArgumentException($"Invalid body type: {bodyType}. Must be one of Saloon, HatchBack, Convertible, CrossOver, MPV.");
            }
        }

        public void Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine($"{Model} is now borrowed.");
            }
            else
            {
                Console.WriteLine($"Error: The {Model} is already on loan.");
            }
        }

        public void ReturnRentalCar()
        {
            Borrowed = false;
            Console.WriteLine($"{Model} has been returned.");
        }

        public void ChangePrice(double price)
        {
            Price = price;
            Console.WriteLine($"{Model}'s price has been updated to {price:C}");
        }

        public double CheckPrice()
        {
            return Price;
        }

        public bool CheckBorrowed()
        {
            return Borrowed;
        }

        public override void Display()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Borrowed: {Borrowed}");
            Console.WriteLine("****************************************\n");
        }
    }

}
