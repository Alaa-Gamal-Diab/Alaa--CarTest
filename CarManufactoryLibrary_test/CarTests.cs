using CarManufactoryLibrary;


namespace CarManufactoryLibrary_test
{
    public class CarTests
    {
        [Fact]
        public void TestCarType()
        {
            //Arrange
            var bmwCar = new BMW();
            var toyotaCar = new Toyota();
            //Act
            string bmwCarType = bmwCar.GetCarTypeAsString();
            string toyotaCarType = toyotaCar.GetCarTypeAsString();
            //Assert
            Assert.NotEmpty(toyotaCarType);
            Assert.NotNull(bmwCarType);
            Assert.Equal("BMW", bmwCarType);
            Assert.StartsWith("T", toyotaCarType);
            Assert.Contains("W", bmwCarType);
            Assert.EndsWith("a", toyotaCarType);
        }
        [Fact]
        public void TestCarReference()
        {
            //Arrange
            var bmwCar1 = new BMW();
            var bmwCar2 = new BMW();
            var toyotaCar1 = new Toyota();
            var toyotaCar2 = new Toyota();
            //Act
            var result = bmwCar1.GetMyCar();
            //Assert
            Assert.Same(bmwCar1, result);
            Assert.NotSame(bmwCar1, bmwCar2);
            Assert.NotSame(bmwCar1, toyotaCar2);
        }
        [Fact]
        public void TestCarTypeAssert()
        {
            //Arrange
            var bmwCar = new BMW();
            var toyotaCar = new Toyota();
            //Assert
            Assert.IsType<BMW>(bmwCar);
            Assert.IsType<Toyota>(toyotaCar);
        }
        [Fact]
        public void testCarCollection()
        {
            //Arrange 
            CarStore carStore = new CarStore();
            CarStore carStore2 = new CarStore();
            var bmw1 = new BMW();
            var bmw2 = new BMW();
            var toyota1 = new Toyota();
            var toyota2 = new Toyota();

            var bmwcars = new List<Car> { bmw1, bmw2 };
            var toyotacars = new List<Car> { toyota1, toyota2 };

            carStore.AddCars(bmwcars);
            carStore2.AddCars(toyotacars);

            //Assert

            Assert.Collection(carStore.cars, car => Assert.NotNull(car), car => Assert.NotNull(car));
            Assert.DoesNotContain(bmwcars, car => car == null);
        }
        [Fact]
        public void testCarException()
        {
            var toyotaCar = new Toyota();

            Assert.Throws<InvalidOperationException>(() => { toyotaCar.ThrowException(); });
        }
    }
}