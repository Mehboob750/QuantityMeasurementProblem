using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasurementProblem;

namespace NUnitTestQuantityMeasurement
{
    class TemperatureTestCases
    {
        private Temperature fahrenheit = null;
        private Temperature celsius = null;
       
        [SetUp]
        public void Setup()
        {
            this.fahrenheit = new Temperature();
            this.celsius = new Temperature();
        }

        /// <summary>
        /// Given 0 Fahrenheit And 0 Fahrenheit Returns the Equal
        /// </summary>
        [Test]
        public void Given0FahrenheitAnd0Fahrenheit_WhenValueChecked_ShouldReturnsEqual()
        {
            double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            Assert.AreEqual(firstFahrenheitValue, secondFahrenheitValue);
        }

        [Test]
        public void Given0FahrenheitAnd1Fahrenheit_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 1.0);
            Assert.AreNotEqual(firstFahrenheitValue, secondFahrenheitValue);
        }

        [Test]
        public void Given0CelsiusAnd0Celsius_WhenValueChecked_ShouldReturnEqual()
        {
            double firstCelsiusValue = celsius.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
            double secondCelsiusValue = celsius.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
            Assert.AreEqual(firstCelsiusValue, secondCelsiusValue);
        }
    }
}
