using NUnit.Framework;
namespace NUnitTestQuantityMeasurement
{
    using QuantityMeasurementProblem;

    public class Tests
    {
        private Length yard = null;
        private Length feet = null;
        private Length inch = null;
        private Length centiMeter = null;

        [SetUp]
        public void Setup()
        {
            this.yard = new Length();
            this.feet = new Length();
            this.inch = new Length();
            this.centiMeter = new Length();

        }

        /// <summary>
        /// Given Zero Feet And Zero Feet Returns the Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnsEqual()
        {
            double firstFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
            double secondFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
            Assert.AreEqual(firstFeet, secondFeet);
        }

        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            double firstFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
            Length secondFeet = null;
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            Length firstFeet = new Length();
            Length secondFeet = new Length();
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length firstFeet = new Length();
            Length secondFeet = new Length();
            secondFeet = firstFeet;
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            double firstFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
            double secondFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
            Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
            double secondFeet = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void Given0InchAnd0Inch_WhenValueChecked_ShouldReturnEqual()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            double secondInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        [Test]
        public void Given0InchAndNull_ShouldReturnsNotEqual()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            Length secondInchValue = null;
            Assert.AreNotEqual(firstInchValue, secondInchValue);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenCheckReference_ShouldReturnFalse()
        {
            Length firstInch = new Length();
            Length secondInch = new Length();
            bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length firstInch = new Length();
            Length secondInch = firstInch;
            bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenTypeChecked_ShouldReturnEqual()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            double SecondInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            Assert.AreEqual(firstInchValue.GetType(), SecondInchValue.GetType());
        }

        [Test]
        public void Given0InchAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            double SecondInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(firstInchValue, SecondInchValue);
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feetValue, inchValue);
        }


        [Test]
        public void Given0FeetAnd0Inch_WhenValueChecked_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 0.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 0.0);
            Assert.AreEqual(feetValue, inchValue);
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqualLength()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feetValue, inchValue);
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenComapringLength_ShouldReturnEqualLength()
        {
            double firstValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double secondValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            Assert.AreEqual(firstValue, secondValue);
        }

        [Test]
        public void Given1InchAnd1Feet_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            Assert.AreNotEqual(inchValue, feetValue);
        }

        [Test]
        public void Given1FeetAnd12Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 12.0);
            Assert.AreEqual(feetValue, inchValue);
        }

        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 12.0);
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            Assert.AreEqual(inchValue, feetValue);
        }

        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double firstYardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            double secondYardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(firstYardValue, secondYardValue);
        }

        [Test]
        public void Given0YardAndNull_ShouldReturnsNotEqual()
        {
            double firstYard = yard.ConvertValueToInch(Length.Unit.YardToInch, 0.0);
            Length secondYard = null;
            Assert.AreNotEqual(firstYard, secondYard);
        }

        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(feetValue, yardValue);
        }

        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            Assert.AreNotEqual(feetValue, yardValue);
        }

        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            Assert.AreNotEqual(inchValue, yardValue);
        }

        [Test]
        public void Given1YardAnd36Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 36.0);
            Assert.AreEqual(yardValue, inchValue);
        }

        [Test]
        public void Given36InchAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 36.0);
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(inchValue, yardValue);
        }

        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 3.0);
            Assert.AreEqual(yardValue, feetValue);
        }

        [Test]
        public void Given0CentiMeterAnd0CentiMeter_WhenComparingLength_ShouldReturnEqualLength()
        {
            double firstCentiMeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeter, 0.0);
            double secondCentiMeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeter, 0.0);
            Assert.AreEqual(firstCentiMeterValue, secondCentiMeterValue);
        }

        [Test]
        public void Given0CentiMeterAndNull_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double firstCentiMeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeter, 0.0);
            Length secondCentiMeterValue = null;
            Assert.AreNotEqual(firstCentiMeterValue, secondCentiMeterValue);
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenCheckReference_ShouldReturnFalse()
        {
            Length firstCentiMeter = new Length();
            Length secondCentimeter = new Length();
            bool areEqual = System.Object.ReferenceEquals(firstCentiMeter, secondCentimeter);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length firstCentiMeter = new Length();
            Length secondCentimeter = firstCentiMeter;
            bool areEqual = System.Object.ReferenceEquals(firstCentiMeter, secondCentimeter);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfCentiMeter_WhenTypeChecked_ShouldReturnEqual()
        {
            double firstCentiMeter = centiMeter.ConvertValueToInch(Length.Unit.CentiMeter, 0.0);
            double secondCentimeter = centiMeter.ConvertValueToInch(Length.Unit.CentiMeter, 1.0);
            Assert.AreEqual(firstCentiMeter.GetType(), secondCentimeter.GetType());
        }

        [Test]
        public void Given2InchAnd5CentiMeter_WhenValueChecked_ShouldReturnEqual()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 2.0);
            double centimeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeterToInch, 5.0);
            Assert.AreEqual(inchValue, centimeterValue);
        }

        [Test]
        public void Given1FeetAnd1CentiMeter_WhenValueChecked_ShouldReturnNotEqual()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double centimeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeterToInch, 1.0);
            Assert.AreNotEqual(feetValue, centimeterValue);
        }

        [Test]
        public void Given1FeetAnd30CentiMeter_WhenValueChecked_ShouldReturnEqual()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double centimeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeterToInch, 30.0);
            Assert.AreEqual(feetValue, centimeterValue);
        }

        [Test]
        public void Given1YardAnd1CentiMeter_WhenValueChecked_ShouldReturnNotEqual()
        {
            double yardValue = inch.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            double centimeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeterToInch, 1.0);
            Assert.AreNotEqual(yardValue, centimeterValue);
        }

        [Test]
        public void Given1InchAnd1Inch_WhenAdded_ShouldReturnSum()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            double secondInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            double ActualValue = inch.AddTWoLengths(firstInchValue, secondInchValue);
            double ExpectedValue = 2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given2InchAnd2Inch_WhenAdded_ShouldReturnSum()
        {
            double firstInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 2.0);
            double secondInchValue = inch.ConvertValueToInch(Length.Unit.Inch, 2.0);
            double ActualValue = inch.AddTWoLengths(firstInchValue, secondInchValue);
            double ExpectedValue = 4.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given1FeetAnd2Inch_WhenAdded_ShouldReturnSum()
        {
            double feetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 2.0);
            double ActualValue = inch.AddTWoLengths(feetValue, inchValue);
            double ExpectedValue = 14.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturnSum()
        {
            double firstFeetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double secondFeetValue = feet.ConvertValueToInch(Length.Unit.FeetToInch, 1.0);
            double ActualValue = inch.AddTWoLengths(firstFeetValue, secondFeetValue);
            double ExpectedValue = 24.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given2InchAnd2andHalfCentimeter_WhenAdded_ShouldReturnSum()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 2.0);
            double centiMeterValue = centiMeter.ConvertValueToInch(Length.Unit.CentiMeterToInch, 2.5);
            double ActualValue = inch.AddTWoLengths(inchValue, centiMeterValue);
            double ExpectedValue = 3.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }

        [Test]
        public void Given1InchAnd1Yard_WhenAdded_ShouldReturnSum()
        {
            double inchValue = inch.ConvertValueToInch(Length.Unit.Inch, 1.0);
            double yardValue = yard.ConvertValueToInch(Length.Unit.YardToInch, 1.0);
            double ActualValue = inch.AddTWoLengths(inchValue, yardValue);
            double ExpectedValue = 37.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}