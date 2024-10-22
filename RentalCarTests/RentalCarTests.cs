namespace RentalCarTests;

using RentalCar;
using NUnit.Framework;

    [TestFixture]
    public class RentalCarTests
    {
        [Test]
        public void Borrow_WhenNotBorrowed_ShouldSetBorrowedToTrue()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, false);

            // Act
            car.Borrow();

            // Assert
            Assert.IsTrue(car.CheckBorrowed(), "Car should be marked as borrowed.");
        }

        [Test]
        public void Borrow_WhenAlreadyBorrowed_ShouldNotChangeBorrowedStatus()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, true);

            // Act
            car.Borrow();  // Attempt to borrow a car that's already borrowed

            // Assert
            Assert.IsTrue(car.CheckBorrowed(), "Car should still be borrowed.");
        }

        [Test]
        public void ReturnRentalCar_WhenBorrowed_ShouldSetBorrowedToFalse()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, true);

            // Act
            car.ReturnRentalCar();

            // Assert
            Assert.IsFalse(car.CheckBorrowed(), "Car should be marked as not borrowed.");
        }

        [Test]
        public void ChangePrice_ShouldUpdatePrice()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, false);

            // Act
            car.ChangePrice(65.00);

            // Assert
            Assert.AreEqual(65.00, car.CheckPrice(), "Price should be updated to 65.00.");
        }

        [Test]
        public void CheckPrice_ShouldReturnCurrentPrice()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, false);

            // Act
            double price = car.CheckPrice();

            // Assert
            Assert.AreEqual(55.00, price, "Price should be 55.00.");
        }

        [Test]
        public void CheckBorrowed_ShouldReturnBorrowedStatus()
        {
            // Arrange
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, true);

            // Act
            bool borrowed = car.CheckBorrowed();

            // Assert
            Assert.IsTrue(borrowed, "Borrowed status should be true.");
        }

        [Test]
        public void Constructor_WithSixParameters_ShouldSetAllProperties()
        {
            // Act
            RentalCar car = new RentalCar("Toyota", "Camry", "Saloon", "ABC123", 55.00, false);

            // Assert
            Assert.AreEqual("Toyota", car.Manufacturer);
            Assert.AreEqual("Camry", car.Model);
            Assert.AreEqual("Saloon", car.BodyType);
            Assert.AreEqual("ABC123", car.RegistrationNumber);
            Assert.AreEqual(55.00, car.CheckPrice());
            Assert.IsFalse(car.CheckBorrowed());
        }

        [Test]
        public void Constructor_WithFiveParameters_ShouldDefaultBorrowedToFalse()
        {
            // Act
            RentalCar car = new RentalCar("Ford", "Focus", "HatchBack", "XYZ456", 40.00);

            // Assert
            Assert.AreEqual("Ford", car.Manufacturer);
            Assert.AreEqual("Focus", car.Model);
            Assert.AreEqual("HatchBack", car.BodyType);
            Assert.AreEqual("XYZ456", car.RegistrationNumber);
            Assert.AreEqual(40.00, car.CheckPrice());
            Assert.IsFalse(car.CheckBorrowed(), "Borrowed should default to false.");
        }

        [Test]
        public void Constructor_WithThreeParameters_ShouldSetDefaultValues()
        {
            // Act
            RentalCar car = new RentalCar("BMW", "Z4", "Convertible");

            // Assert
            Assert.AreEqual("BMW", car.Manufacturer);
            Assert.AreEqual("Z4", car.Model);
            Assert.AreEqual("Convertible", car.BodyType);
            Assert.AreEqual("Unknown", car.RegistrationNumber);
            Assert.AreEqual(0.0, car.CheckPrice(), "Price should default to 0.0.");
            Assert.IsFalse(car.CheckBorrowed(), "Borrowed should default to false.");
        }
    }

