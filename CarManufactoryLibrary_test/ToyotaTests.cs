using CarManufactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufactoryLibrary_test
{
    public class ToyotaTests
    {
        [Theory]
        /*[InlineData(0,100,0)] // v = 0, d = 0
        [InlineData(0,0,100)] // v = 0, d!= 0*/
        [InlineData(100, 0, 0)] // v!= 0, d = 0
        [InlineData(100, 200, 2)] // v!= 0, d!= 0
        [InlineData(100, -50, -0.5)] // v = + , d = -
        [InlineData(-50, 200, -4)] // v = -, d = +
        [InlineData(-50, -100, 2)] // v = -, d = -
        public void TestTimeToCoverDistanceToyota(double velocity, double distance, double expectedTime)
        {
            //Arrange
            var toyotaCar = new Toyota() { velocity = velocity };
            //Act
            double actualTime = toyotaCar.TimeToCoverDistance(distance);
            //Assert
            Assert.Equal(expectedTime, actualTime);
        }
    }
}
