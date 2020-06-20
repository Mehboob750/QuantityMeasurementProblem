using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasurementProblem;

namespace NUnitTestQuantityMeasurement
{
    class WeightTestCases
    {
        private Weight kiloGram = null;
        private Weight gram = null;

        [SetUp]
        public void Setup()
        {
            this.kiloGram = new Weight();
            this.gram = new Weight();
        }

        /// <summary>
        /// Given Zero KiloGrams And Zero KiloGrams Returns the Equal
        /// </summary>
        [Test]
        public void Given0KiloGramsAnd0KiloGrams_ShouldReturnsEqual()
        {
            double firstKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            double secondKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            Assert.AreEqual(firstKiloGramsValue, secondKiloGramsValue);
        }

        [Test]
        public void Given0KiloGramsAnd1KiloGrams_ShouldReturnsEqual()
        {
            double firstKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 0.0);
            double secondKiloGramsValue = kiloGram.ConvertValueToKiloGrams(Weight.Unit.KiloGrams, 1.0);
            Assert.AreNotEqual(firstKiloGramsValue, secondKiloGramsValue);
        }

        [Test]
        public void Given0GramsAnd0Grams_ShouldReturnsEqual()
        {
            double firstGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            double secondGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            Assert.AreEqual(firstGramsValue, secondGramsValue);
        }

        [Test]
        public void Given0GramsAnd1Grams_ShouldReturnsEqual()
        {
            double firstGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 0.0);
            double secondGramsValue = gram.ConvertValueToKiloGrams(Weight.Unit.GramsToKiloGrams, 1.0);
            Assert.AreNotEqual(firstGramsValue, secondGramsValue);
        }
    }
}
