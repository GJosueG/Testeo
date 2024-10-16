using Microsoft.VisualStudio.TestTools.UnitTesting;
using GJGZ.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GJGZ.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            //Arrange
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            //Act 
            double fahrenheit = temperatureConverter.CelsiusToFahrenheit(25.0);

            //Assert
            Assert.AreEqual(77.0, fahrenheit, 0.001, "La conversión de celcius a fahrenheit no es correcta.");
        }

        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            //Arrange
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            //Act 
            double celcius = temperatureConverter.FahrenheitToCelsius(77.0);

            //Assert
            Assert.AreEqual(25.0, celcius, 0.001, "La conversión de fahrenheit a celcius no es correcta."); ;
        }
    }
}