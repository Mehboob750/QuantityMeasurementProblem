//-----------------------------------------------------------------------
// <copyright file="TemperatureTestCases.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Mehboob Shaikh</author>
//-----------------------------------------------------------------------
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace NUnitTestQuantityMeasurement
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// This class Contains the TestCases to check the functionality of Temperature Class
    /// </summary>
    public class TemperatureTestCases
    {
        /// <summary>
        /// Created Reference of Temperature Class to Access it Globally
        /// </summary>
        private Temperature temperature = null;

        /// <summary>
        /// Created the Object of Temperature Class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.temperature = new Temperature();
        }

        /// <summary>
        /// Given 0.0 Fahrenheit And 0.0 Fahrenheit When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given0FahrenheitAnd0Fahrenheit_WhenValueChecked_ShouldReturnsEqual()
        {
            try
            {
                double firstFahrenheitValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                double secondFahrenheitValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                Assert.AreEqual(firstFahrenheitValue, secondFahrenheitValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Fahrenheit And 1.0 Fahrenheit When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0FahrenheitAnd1Fahrenheit_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstFahrenheitValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 0.0);
                double secondFahrenheitValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Fahrenheit, 1.0);
                Assert.AreNotEqual(firstFahrenheitValue, secondFahrenheitValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Celsius And 0.0 Celsius When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given0CelsiusAnd0Celsius_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstCelsiusValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
                double secondCelsiusValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
                Assert.AreEqual(firstCelsiusValue, secondCelsiusValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Celsius And 1.0 Celsius When Value Checked Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0CelsiusAnd1Celsius_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstCelsiusValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Celsius, 0.0);
                double secondCelsiusValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Celsius, 1.0);
                Assert.AreNotEqual(firstCelsiusValue, secondCelsiusValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 212.0 Fahrenheit And 100.0 Celsius When Value Checked Returns the Equal
        /// </summary>
        [Test]
        public void Given212FahrenheitAnd100Celsius_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double fahrenheitValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.FahrenheitToCelsius, 212.0);
                double celsiusValue = this.temperature.ConvertValueToCelsius(Temperature.Unit.Celsius, 100.0);
                Assert.AreEqual(fahrenheitValue, celsiusValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }
    }
}
