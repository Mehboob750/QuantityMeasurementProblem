using NUnit.Framework;
namespace NUnitTestQuantityMeasurement
{
    using QuantityMeasurementProblem;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Given Zero Feet And Zero Feet Returns the Equal
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnsEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(firstFeet,secondFeet);
        }

        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = null;
            Assert.AreNotEqual(firstFeet,secondFeet);
        }

        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 0.0);
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = firstFeet;
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 3.0);
            Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }

        [Test]
        public void Given0InchAnd0Inch_WhenValueChecked_ShouldReturnEqual()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(firstInch, secondInch);
        }

        [Test]
        public void Given0InchAndNull_ShouldReturnsNotEqual()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = null;
            Assert.AreNotEqual(firstInch, secondInch);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenCheckReference_ShouldReturnFalse()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 0.0);
            bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = firstInch;
            bool areEqual = System.Object.ReferenceEquals(firstInch, secondInch);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjectsOfInch_WhenTypeChecked_ShouldReturnEqual()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 3.0);
            Assert.AreEqual(firstInch.GetType(), secondInch.GetType());
        }

        [Test]
        public void Given0InchAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(firstInch, secondInch);
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 1.0);
            Length firstInch = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(firstFeet, firstInch);
        }

        [Test]
        public void Given0FeetAnd0Inch_WhenValueChecked_ShouldReturnEqualLength()
        {
            Length feetValue = new Length(Length.Unit.FEET, 0.0);
            Length inchValue = new Length(Length.Unit.INCH, 0.0);
            bool compareCheck = feetValue.Compare(inchValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenValueChecked_ShouldReturnNotEqualLength()
        {
            Length feetValue = new Length(Length.Unit.FEET, 1.0);
            Length inchValue = new Length(Length.Unit.INCH, 1.0);
            bool compareCheck = feetValue.Compare(inchValue);
            Assert.IsFalse(compareCheck);
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenComapringLength_ShouldReturnEqualLength()
        {
            Length firstFeetValue = new Length(Length.Unit.FEET, 1.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = firstFeetValue.Compare(secondFeetValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given1InchAnd1Feet_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            Length inchValue = new Length(Length.Unit.INCH, 1.0);
            Length feetValue = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = inchValue.Compare(feetValue);
            Assert.IsFalse(compareCheck);
        }

        [Test]
        public void Given1FeetAnd12Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            Length feetValue = new Length(Length.Unit.FEET, 1.0);
            Length inchValue = new Length(Length.Unit.INCH, 12.0);
            bool compareCheck = feetValue.Compare(inchValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given12InchAnd1Feet_WhenComparingLength_ShouldReturnEqualLength()
        {
            Length inchValue = new Length(Length.Unit.INCH, 12.0);
            Length feetValue = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = inchValue.Compare(feetValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given1YardAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            Length firstYardValue = new Length(Length.Unit.YARD, 1.0);
            Length secondYardValue = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = firstYardValue.Compare(secondYardValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given3FeetAnd1Yard_WhenComparingLength_ShouldReturnEqualLength()
        {
            Length feetValue = new Length(Length.Unit.FEET, 3.0);
            Length yardValue = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = feetValue.Compare(yardValue);
            Assert.IsTrue(compareCheck);
        }

        [Test]
        public void Given1FeetAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            Length feetValue = new Length(Length.Unit.FEET, 1.0);
            Length yardValue = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = feetValue.Compare(yardValue);
            Assert.IsFalse(compareCheck);
        }

        [Test]
        public void Given1InchAnd1Yard_WhenComparingLength_ShouldReturnNotEqualLength()
        {
            Length inchValue = new Length(Length.Unit.INCH, 1.0);
            Length yardValue = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = inchValue.Compare(yardValue);
            Assert.IsFalse(compareCheck);
        }

        [Test]
        public void Given1YardAnd36Inch_WhenComparingLength_ShouldReturnEqualLength()
        {
            Length yardValue = new Length(Length.Unit.YARD, 1.0);
            Length inchValue = new Length(Length.Unit.INCH, 36.0);
            bool compareCheck = yardValue.Compare(inchValue);
            Assert.IsTrue(compareCheck);
        }
    }
}