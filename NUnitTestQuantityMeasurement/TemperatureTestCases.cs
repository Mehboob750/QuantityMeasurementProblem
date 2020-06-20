﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasurementProblem;

namespace NUnitTestQuantityMeasurement
{
    class TemperatureTestCases
    {
        private Temperature fahrenheit = null;
       
        [SetUp]
        public void Setup()
        {
            this.fahrenheit = new Temperature();
        }

        /// <summary>
        /// Given 0 Fahrenheit And 0 Fahrenheit Returns the Equal
        /// </summary>
        [Test]
        public void Given0FahrenheitAnd0Fahrenheit_ShouldReturnsEqual()
        {
            double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            Assert.AreEqual(firstFahrenheitValue, secondFahrenheitValue);
        }

        [Test]
        public void Given0FahrenheitAnd1Fahrenheit_ShouldReturnNotEqual()
        {
            double firstFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
            double secondFahrenheitValue = fahrenheit.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 1.0);
            Assert.AreNotEqual(firstFahrenheitValue, secondFahrenheitValue);
        }
    }
}
