using CarManufactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufactoryLibrary_test
{
    public class BMWTests
    {
        [Fact]
        public void TestIsStoppedWhenVelocityIsZero()
        {
            //Arrange
            var bmwCar = new BMW() { velocity = 0 };
            //Act
            bool isStopped = bmwCar.IsStopped();
            //Assert
            Assert.True(isStopped);
        }
        [Fact]
        public void TestIsStoppedWhenVelocityIsGreaterThanZero()
        {
            //Arrange
            var bmwCar = new BMW() { velocity = 50 };
            //Act
            bool isStopped = bmwCar.IsStopped();
            //Assert
            Assert.False(isStopped);
        }
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 50)]
        [InlineData(50, -20)]
        [InlineData(50, 30)]
        public void TestIncreaseVelocityBmw(double initialVelocity, double addedVelocity)
        {
            //Arrange
            var bmwcar = new BMW() { velocity = initialVelocity };
            //Act
            bmwcar.IncreaseVelocity(addedVelocity);
            //Assert
            double expectedVelocity = initialVelocity + addedVelocity;
            Assert.Equal(expectedVelocity, bmwcar.velocity);
        }
    }
}
