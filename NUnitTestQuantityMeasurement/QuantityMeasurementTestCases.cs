using NUnit.Framework;
namespace NUnitTestQuantityMeasurement
{
    using QuantityMeasurementProblem;

    public class Tests
    {
        private Length yard = null;
        private Length feet = null;
        private Length inch = null;

        [SetUp]
        public void Setup()
        {
            this.yard = new Length();
            this.feet = new Length();
            this.inch = new Length();
        }

        /// <summary>
        /// Given Zero Feet And Zero Feet Returns the Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnsEqual()
        {
            double firstFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 0.0);
            double secondFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 0.0);
            Assert.AreEqual(firstFeet, secondFeet);
        }
        
        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            double firstFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 0.0);
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
            double firstFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 3.0);
            double secondFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 3.0);
            Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 0.0);
            double secondFeet = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void Given0InchAnd0Inch_WhenValueChecked_ShouldReturnEqual()
        {
            double firstInchValue = inch.ConvertTheValue(Length.Unit.Inch, 0.0);
            double secondInchValue = inch.ConvertTheValue(Length.Unit.Inch, 0.0);
            Assert.AreEqual(firstInchValue, secondInchValue);
        }

        [Test]
        public void Given0InchAndNull_ShouldReturnsNotEqual()
        {
            double firstInchValue = inch.ConvertTheValue(Length.Unit.Inch, 0.0);
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
            double firstInchValue = inch.ConvertTheValue(Length.Unit.Inch, 0.0);
            double SecondInchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            Assert.AreEqual(firstInchValue.GetType(), SecondInchValue.GetType());
        }

        [Test]
        public void Given0InchAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            double firstInchValue = inch.ConvertTheValue(Length.Unit.Inch, 0.0);
            double SecondInchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(firstInchValue, SecondInchValue);
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feetValue, inchValue);
        }

        
        [Test]
        public void Given0FeetAnd0Inch_WhenValueChecked_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch,0.0);
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch,0.0);
            Assert.AreEqual(feetValue, inchValue);
        }
        
        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqualLength()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            Assert.AreNotEqual(feetValue, inchValue);
        }
        
        [Test]
        public void Given1FeetAnd1Feet_WhenComapringLength_ShouldReturnEqualLength()
        {
            double firstValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            double secondValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            Assert.AreEqual(firstValue, secondValue);
        }
        
        [Test]
        public void Given1InchAnd1Feet_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            Assert.AreNotEqual(inchValue,feetValue);
        }
        
        [Test]
        public void Given1FeetAnd12Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 12.0);
            Assert.AreEqual(feetValue, inchValue);
        }
        
        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 12.0);
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            Assert.AreEqual(inchValue, feetValue);
        }
        
        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double firstYardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            double secondYardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(firstYardValue, secondYardValue);
        }
        
        [Test]
        public void Given0YardAndNull_ShouldReturnsNotEqual()
        {
            double firstYard = yard.ConvertTheValue(Length.Unit.YardToInch, 0.0);
            Length secondYard = null;
            Assert.AreNotEqual(firstYard, secondYard);
        }
        
        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 3.0);
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(feetValue, yardValue);
        }
        
        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 1.0);
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            Assert.AreNotEqual(feetValue, yardValue);
        }
        
        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 1.0);
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            Assert.AreNotEqual(inchValue, yardValue);
        }
        
        [Test]
        public void Given1YardAnd36Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 36.0);
            Assert.AreEqual(yardValue, inchValue);
        }
        
        [Test]
        public void Given36InchAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            double inchValue = inch.ConvertTheValue(Length.Unit.Inch, 36.0);
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            Assert.AreEqual(inchValue, yardValue);
        }
        
        [Test]
        public void Given1YardAnd3Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            double yardValue = yard.ConvertTheValue(Length.Unit.YardToInch, 1.0);
            double feetValue = feet.ConvertTheValue(Length.Unit.FeetToInch, 3.0);
            Assert.AreEqual(yardValue, feetValue);
        }
        
       
    }
}