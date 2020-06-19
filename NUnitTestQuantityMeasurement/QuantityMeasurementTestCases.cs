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
    }
}