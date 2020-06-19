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
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(0.0);
            Assert.AreEqual(firstFeet,secondFeet);
        }

        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = null;
            Assert.AreNotEqual(firstFeet,secondFeet);
        }

        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(0.0);
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsFalse(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = firstFeet;
            bool areEqual = System.Object.ReferenceEquals(firstFeet, secondFeet);
            Assert.IsTrue(areEqual);
        }

        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(3.0);
            Assert.AreEqual(firstFeet.GetType(), secondFeet.GetType());
        }

        [Test]
        public void Given0FeetAnd1Feet_WhenValueChecked_ShouldReturnNotEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }
    }
}