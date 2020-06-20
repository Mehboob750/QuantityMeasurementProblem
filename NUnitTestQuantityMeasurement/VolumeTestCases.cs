using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuantityMeasurementProblem;

namespace NUnitTestQuantityMeasurement
{
    class VolumeTestCases
    {
        private Volume litre = null;
        private Volume gallon = null;

        [SetUp]
        public void Setup()
        {
            this.litre = new Volume();
            this.gallon = new Volume();
        }

        /// <summary>
        /// Given Zero gallon And Zero gallon Returns the Equal
        /// </summary>
        [Test]
        public void Given0GallonAnd0Gallon_ShouldReturnsEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            double secondGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            Assert.AreEqual(firstGallonValue, secondGallonValue);
        }

        [Test]
        public void Given0GallonAndNull_ShouldReturnsNotEqual()
        {
            double firstGallonValue = gallon.ConvertValueToInch(Volume.Unit.Gallon, 0.0);
            Volume secondGallonValue = null;
            Assert.AreNotEqual(firstGallonValue, secondGallonValue);
        }
    }
}
