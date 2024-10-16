using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GJGZ.Temperatura
{
    public class TemperatureConverter
    {
        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Implementa la conversión de Fahrenheit a Celsius
            return (fahrenheit - 32) * 5 / 9;
        }

        public double CelsiusToFahrenheit(double celsius)
        {
            // Implementa la conversión de Celsius a Fahrenheit
            return (celsius * 9 / 5) + 32;
        }
    }
}
