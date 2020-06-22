//-----------------------------------------------------------------------
// <copyright file="LengthTestCases.cs" company="BridgeLabz Solution">
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
    /// This class Contains the TestCases to check the functionality of Length Class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Created Reference of Length Class to Access it Globally
        /// </summary>
        private Length length = null;

        /// <summary>
        /// Created the Object of Length Class
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.length = new Length();
        }

        /// <summary>
        /// Given 0.0 Feet And 0.0 Feet Returns the Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnsEqual()
        {
            try
            {
                double firstFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
                double secondFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
                Assert.AreEqual(firstFeet, secondFeet);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Feet And Null Returns the Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
                Length secondFeet = null;
                Assert.AreNotEqual(firstFeet, secondFeet);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given Two Objects When Reference Checked Returns Not Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Length firstFeet = new Length();
                Length secondFeet = new Length();
                bool result = object.ReferenceEquals(firstFeet, secondFeet);
                Assert.IsFalse(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When First Assign to Second And Reference Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstFeet = new Length();
                Length secondFeet = new Length();
                secondFeet = firstFeet;
                bool result = object.ReferenceEquals(firstFeet, secondFeet);
                Assert.IsTrue(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When Type Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
                double secondFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
                Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Feet and 1.0 Feet when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
                double secondFeet = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                Assert.AreNotEqual(firstFeet, secondFeet);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Inch and 0.0 Inch when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                double secondInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                Assert.AreEqual(firstInchValue, secondInchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Inch and Null  when checked returns Not Equal
        /// </summary>
        [Test]
        public void Given0InchAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                Length secondInchValue = null;
                Assert.AreNotEqual(firstInchValue, secondInchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given Two Objects When Reference Checked Returns Not Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfInch_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Length firstInch = new Length();
                Length secondInch = new Length();
                bool result = object.ReferenceEquals(firstInch, secondInch);
                Assert.IsFalse(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When First Assign to Second And Reference Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfInch_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstInch = new Length();
                Length secondInch = firstInch;
                bool areEqual = object.ReferenceEquals(firstInch, secondInch);
                Assert.IsTrue(areEqual);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When Type Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfInch_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                double secondInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Inch and 1.0 Inch when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given0InchAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                double secondInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(firstInchValue, secondInchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Inch when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(feetValue, inchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Feet and 0.0 Inch when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenValueChecked_ShouldReturnEqualLength()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 0.0);
                Assert.AreEqual(feetValue, inchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Inch when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqualLength()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                Assert.AreNotEqual(feetValue, inchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Inch and 0.0 Inch when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenComapringLength_ShouldReturnEqualLength()
        {
            try
            {
                double firstValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double secondValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                Assert.AreEqual(firstValue, secondValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Inch and 1.0 Feet when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1InchAnd1Feet_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                Assert.AreNotEqual(inchValue, feetValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 12.0 Inch when Value checked returns Equal 
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 12.0);
                Assert.AreEqual(feetValue, inchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 12.0 Inch and 1.0 Feet when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 12.0);
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                Assert.AreEqual(inchValue, feetValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Yard and 1.0 Yard when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double firstYardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double secondYardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                Assert.AreEqual(firstYardValue, secondYardValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Yard and Null when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given0YardAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double firstYard = this.length.ConvertValueToInch(Length.Unit.YardToInch, 0.0);
                Length secondYard = null;
                Assert.AreNotEqual(firstYard, secondYard);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 3.0 Feet and 1.0 Yard when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                Assert.AreEqual(feetValue, yardValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Yard when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(feetValue, yardValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Inch and 1.0 Yard when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                Assert.AreNotEqual(inchValue, yardValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Yard and 36.0 Inch when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 36.0);
                Assert.AreEqual(yardValue, inchValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 36.0 Inch and 1.0 Yard when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 36.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                Assert.AreEqual(inchValue, yardValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Yard and 3.0 Feet when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
                Assert.AreEqual(yardValue, feetValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Cm and 0.0 Cm when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given0CentiMetreAnd0CentiMetre_WhenComparingLength_ShouldReturnEqualLength()
        {
            try
            {
                double firstCentiMeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 0.0);
                double secondCentiMeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 0.0);
                Assert.AreEqual(firstCentiMeterValue, secondCentiMeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 0.0 Cm and Null when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given0CentiMeterAndNull_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            try
            {
                double firstCentiMeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 0.0);
                Length secondCentiMeterValue = null;
                Assert.AreNotEqual(firstCentiMeterValue, secondCentiMeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given Two Objects When Reference Checked Returns Not Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Length firstCentiMeter = new Length();
                Length secondCentimeter = new Length();
                bool result = object.ReferenceEquals(firstCentiMeter, secondCentimeter);
                Assert.IsFalse(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When First Assign to Second And Reference Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length firstCentiMeter = new Length();
                Length secondCentimeter = firstCentiMeter;
                bool result = object.ReferenceEquals(firstCentiMeter, secondCentimeter);
                Assert.IsTrue(result);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        ///  Given Two Objects When Type Checked Returns Equal
        /// </summary>
        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double firstCentiMeter = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 0.0);
                double secondCentimeter = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 1.0);
                Assert.AreEqual(firstCentiMeter.GetType(), secondCentimeter.GetType());
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 2.0 Inch and 5.0 Cm when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given2InchAnd5CentiMeter_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 2.0);
                double centimeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 5.0);
                Assert.AreEqual(inchValue, centimeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Cm when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1CentiMeter_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double centimeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 1.0);
                Assert.AreNotEqual(feetValue, centimeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 30.0 Cm when Value checked returns Equal
        /// </summary>
        [Test]
        public void Given1FeetAnd30CentiMeter_WhenValueChecked_ShouldReturnEqual()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double centimeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 30.0);
                Assert.AreEqual(feetValue, centimeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Yard and 1.0 Cm when Value checked returns Not Equal
        /// </summary>
        [Test]
        public void Given1YardAnd1CentiMeter_WhenValueChecked_ShouldReturnNotEqual()
        {
            try
            {
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double centimeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 1.0);
                Assert.AreNotEqual(yardValue, centimeterValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Inch and 1.0 Inch when Added returns 2.0
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                double secondInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                double actualValue = this.length.AddTWoLengths(firstInchValue, secondInchValue);
                double expectedValue = 2.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 2.0 Inch and 2.0 Inch when Added returns 4.0
        /// </summary>
        [Test]
        public void Given2InchAnd2Inch_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 2.0);
                double secondInchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 2.0);
                double actualValue = this.length.AddTWoLengths(firstInchValue, secondInchValue);
                double expectedValue = 4.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 2.0 Inch when Added returns 14.0
        /// </summary>
        [Test]
        public void Given1FeetAnd2Inch_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 2.0);
                double actualValue = this.length.AddTWoLengths(feetValue, inchValue);
                double expectedValue = 14.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Feet when Added returns 24.0
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double firstFeetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double secondFeetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double actualValue = this.length.AddTWoLengths(firstFeetValue, secondFeetValue);
                double expectedValue = 24.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 2.0 Inch and 2.5 Cm when Added returns 3.0
        /// </summary>
        [Test]
        public void Given2InchAnd2andHalfCentimeter_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 2.0);
                double centiMeterValue = this.length.ConvertValueToInch(Length.Unit.CentiMeterToInch, 2.5);
                double actualValue = this.length.AddTWoLengths(inchValue, centiMeterValue);
                double expectedValue = 3.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Inch and 1.0 Yard when Added returns 37.0
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double inchValue = this.length.ConvertValueToInch(Length.Unit.Inch, 1.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double actualValue = this.length.AddTWoLengths(inchValue, yardValue);
                double expectedValue = 37.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }

        /// <summary>
        /// Given 1.0 Feet and 1.0 Yard when Added returns 48.0
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenAdded_ShouldReturnSum()
        {
            try
            {
                double feetValue = this.length.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
                double yardValue = this.length.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
                double actualValue = this.length.AddTWoLengths(feetValue, yardValue);
                double expectedValue = 48.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMeasurementException e)
            {
                Assert.AreEqual(QuantityMeasurementException.ExceptionType.InvalidValue, e.type);
            }
        }
    }
}