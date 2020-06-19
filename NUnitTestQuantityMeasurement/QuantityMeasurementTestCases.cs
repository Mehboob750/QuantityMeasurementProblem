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
        public void Given0FeetAnd1Feet_ShouldReturnsNotEqual()
        {
            Feet firstFeet = new Feet(0.0);
            Feet secondFeet = new Feet(1.0);
            Assert.AreNotEqual(firstFeet, secondFeet);
        }
    }
}